using System;
using System.Collections.Generic;

namespace Burpless.Configuration
{
    public class DialectBuilder
    {
        private readonly string _name;
        private readonly string _code;

        private readonly Dictionary<KeywordType, string[]> _keywords = new Dictionary<KeywordType, string[]>();

        public DialectBuilder(string name, string code)
        {
            _name = name;
            _code = code;
        }

        public static DialectBuilder Create(string name, string code)
        {
            return new DialectBuilder(name, code);
        }

        public DialectBuilder Feature(params string[] keywords)
        {
            _keywords[KeywordType.Feature] = keywords;

            return this;
        }

        public DialectBuilder Background(params string[] keywords)
        {
            _keywords[KeywordType.Background] = keywords;

            return this;
        }

        public DialectBuilder Scenario(Action<DialectScenarioBuilder> action)
        {
            var builder = new DialectScenarioBuilder(_keywords);
            action(builder);

            return this;
        }

        public DialectBuilder Steps(Action<DialectStepsBuilder> action)
        {
            var builder = new DialectStepsBuilder(_keywords);
            action(builder);

            return this;
        }

        public void Register()
        {
            Dialect.Register(_name, _code, _keywords);
        }
    }
}
