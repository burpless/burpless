using System.Collections.Generic;

namespace Burpless.Configuration
{
    public class DialectScenarioBuilder
    {
        private readonly Dictionary<KeywordType, string[]> _keywords;

        internal DialectScenarioBuilder(Dictionary<KeywordType, string[]> keywords)
        {
            _keywords = keywords;
        }

        public DialectScenarioBuilder Scenario(params string[] keywords)
        {
            _keywords[KeywordType.Scenario] = keywords;

            return this;
        }

        public DialectScenarioBuilder ScenarioOutline(params string[] keywords)
        {
            _keywords[KeywordType.ScenarioOutline] = keywords;

            return this;
        }

        public DialectScenarioBuilder Examples(params string[] keywords)
        {
            _keywords[KeywordType.Examples] = keywords;

            return this;
        }
    }
}
