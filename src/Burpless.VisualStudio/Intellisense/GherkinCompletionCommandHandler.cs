using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Burpless.VisualStudio.Intellisense
{
    public class GherkinCompletionCommandHandler : IOleCommandTarget
    {
        private readonly ITextView _textView;
        private readonly GherkinCompletionHandlerProvider _provider;
        private readonly IOleCommandTarget _nextCommandHandler;

        private ICompletionSession _session;

        public GherkinCompletionCommandHandler(IVsTextView textViewAdapter, ITextView textView, GherkinCompletionHandlerProvider provider)
        {
            _textView = textView;
            _provider = provider;

            textViewAdapter.AddCommandFilter(this, out _nextCommandHandler);
        }

        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            return _nextCommandHandler.QueryStatus(ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }

        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            if (VsShellUtilities.IsInAutomationFunction(_provider.ServiceProvider))
                return _nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);

            var commandID = nCmdID;
            var typedChar = char.MinValue;

            if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint) VSConstants.VSStd2KCmdID.TYPECHAR)
                typedChar = (char) (ushort) Marshal.GetObjectForNativeVariant(pvaIn);

            if (nCmdID == (uint)VSConstants.VSStd2KCmdID.RETURN || nCmdID == (uint)VSConstants.VSStd2KCmdID.TAB || char.IsWhiteSpace(typedChar) || char.IsPunctuation(typedChar))
            {
                if (_session != null && !_session.IsDismissed)
                {
                    if (_session.SelectedCompletionSet.SelectionStatus.IsSelected)
                    {
                        _session.Commit();
                        return VSConstants.S_OK;
                    }

                    _session.Dismiss();
                }
            }

            var retVal = _nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
            var handled = false;

            if (!typedChar.Equals(char.MinValue) && char.IsLetterOrDigit(typedChar))
            {
                if (_session == null || _session.IsDismissed)
                {
                    TriggerCompletion();
                    _session.Filter();
                }
                else
                {
                    _session.Filter();
                }

                handled = true;
            }
            else if (commandID == (uint)VSConstants.VSStd2KCmdID.BACKSPACE || commandID == (uint)VSConstants.VSStd2KCmdID.DELETE)
            {
                if (_session != null && !_session.IsDismissed)
                    _session.Filter();

                handled = true;
            }

            if (handled)
                return VSConstants.S_OK;

            return retVal;
        }

        private bool TriggerCompletion()
        {
            var caretPoint = _textView.Caret.Position.Point.GetPoint(textBuffer => (!textBuffer.ContentType.IsOfType("projection")), PositionAffinity.Predecessor);

            if (!caretPoint.HasValue)
                return false;

            _session = _provider.CompletionBroker.CreateCompletionSession(_textView, caretPoint.Value.Snapshot.CreateTrackingPoint(caretPoint.Value.Position, PointTrackingMode.Positive), true);

            _session.Dismissed += OnSessionDismissed;
            _session.Start();

            return true;
        }

        private void OnSessionDismissed(object sender, EventArgs e)
        {
            _session.Dismissed -= this.OnSessionDismissed;
            _session = null;
        }
    }
}
