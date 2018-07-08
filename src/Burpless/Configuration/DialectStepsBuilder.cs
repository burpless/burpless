using System.Collections.Generic;

namespace Burpless.Configuration
{
    public class DialectStepsBuilder
    {
        private readonly Dictionary<KeywordType, string[]> _keywords;

        internal DialectStepsBuilder(Dictionary<KeywordType, string[]> keywords)
        {
            _keywords = keywords;
        }

        public DialectStepsBuilder Given(params string[] keywords)
        {
            _keywords[KeywordType.Given] = keywords;

            return this;
        }

        public DialectStepsBuilder When(params string[] keywords)
        {
            _keywords[KeywordType.When] = keywords;

            return this;
        }

        public DialectStepsBuilder Then(params string[] keywords)
        {
            _keywords[KeywordType.Then] = keywords;

            return this;
        }

        public DialectStepsBuilder And(params string[] keywords)
        {
            _keywords[KeywordType.And] = keywords;

            return this;
        }

        public DialectStepsBuilder But(params string[] keywords)
        {
            _keywords[KeywordType.But] = keywords;

            return this;
        }
    }
}
