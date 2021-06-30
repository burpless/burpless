using System.Collections.Generic;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;

namespace Burpless.VisualStudio.Intellisense
{
    public class GherkinCompletionSource : ICompletionSource
    {
        private readonly GherkinCompletionSourceProvider _provider;
        private readonly ITextBuffer _textBuffer;

        private List<Completion> _completionList;

        public GherkinCompletionSource(GherkinCompletionSourceProvider provider, ITextBuffer textBuffer)
        {
            _provider = provider;
            _textBuffer = textBuffer;
        }

        public void AugmentCompletionSession(ICompletionSession session, IList<CompletionSet> completionSets)
        {
            var strList = new List<string> {"addition", "adaptation", "subtraction", "summation"};

            _completionList = new List<Completion>();

            foreach (string str in strList)
                _completionList.Add(new Completion(str, str, str, null, null));

            completionSets.Add(new CompletionSet(
                "Tokens",
                "Tokens",
                FindTokenSpanAtPosition(session.GetTriggerPoint(_textBuffer),
                    session),
                _completionList,
                null));
        }

        private ITrackingSpan FindTokenSpanAtPosition(ITrackingPoint point, ICompletionSession session)
        {
            var currentPoint = session.TextView.Caret.Position.BufferPosition - 1;
            var navigator = _provider.NavigatorService.GetTextStructureNavigator(_textBuffer);
            var extent = navigator.GetExtentOfWord(currentPoint);

            return currentPoint.Snapshot.CreateTrackingSpan(extent.Span, SpanTrackingMode.EdgeInclusive);
        }

        public void Dispose()
        {
        }
    }
}
