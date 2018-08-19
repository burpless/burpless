using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Burpless.VisualStudio
{
    [Export(typeof(IVsTextViewCreationListener))]
    [TextViewRole(PredefinedTextViewRoles.PrimaryDocument)]
    public class TextViewCreationListener : IVsTextViewCreationListener
    {
        [Import]
        public IVsEditorAdaptersFactoryService AdaptersFactory { get; set; }

        public void VsTextViewCreated(IVsTextView textViewAdapter)
        {
            var view = AdaptersFactory.GetWpfTextView(textViewAdapter);
        }
    }
}
