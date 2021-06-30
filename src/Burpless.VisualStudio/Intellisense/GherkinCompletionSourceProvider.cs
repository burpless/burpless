using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Utilities;

namespace Burpless.VisualStudio.Intellisense
{
    [Export(typeof(ICompletionSourceProvider))]
    [ContentType("plaintext")]
    [Name("Burpless")]
    public class GherkinCompletionSourceProvider : ICompletionSourceProvider
    {
        [Import]
        internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }

        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new GherkinCompletionSource(this, textBuffer);
        }
    }
}
