using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Utilities;

namespace Burpless.VisualStudio.Intellisense
{
    [Export(typeof(IVsTextViewCreationListener))]
    [Name("Gherkin Completion Handler")]
    [ContentType("plaintext")]
    [TextViewRole(PredefinedTextViewRoles.Editable)]
    public class GherkinCompletionHandlerProvider : IVsTextViewCreationListener
    {
        [Import]
        public IVsEditorAdaptersFactoryService AdapterService { get; set; }

        [Import]
        public ICompletionBroker CompletionBroker { get; set; }

        [Import]
        public SVsServiceProvider ServiceProvider { get; set; }

        public void VsTextViewCreated(IVsTextView textViewAdapter)
        {
            var textView = AdapterService.GetWpfTextView(textViewAdapter);

            if (textView == null)
                return;

            Func<GherkinCompletionCommandHandler> handler = () => new GherkinCompletionCommandHandler(textViewAdapter, textView, this);

            textView.Properties.GetOrCreateSingletonProperty(handler);
        }
    }
}
