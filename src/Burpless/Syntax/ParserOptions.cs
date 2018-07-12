using Burpless.Configuration;

namespace Burpless.Syntax
{
    public class ParserOptions
    {
        public ParserOptions(Dialect defaultDialect = null, LanguageVersion languageVersion = LanguageVersion.Latest)
        {
            DefaultDialect = defaultDialect ?? Dialect.Default;
            LanguageVersion = languageVersion;
        }

        private ParserOptions(ParserOptions options)
            : this(options.DefaultDialect, options.LanguageVersion)
        {
        }

        public static ParserOptions Default { get; } = new ParserOptions();

        public Dialect DefaultDialect { get; private set; }

        public LanguageVersion LanguageVersion { get; private set; }

        public ParserOptions WithLanguageVersion(LanguageVersion languageVersion)
        {
            return new ParserOptions(this)
            {
                LanguageVersion = languageVersion
            };
        }

        public ParserOptions WithDefaultDialect(Dialect defaultDialect)
        {
            return new ParserOptions(this)
            {
                DefaultDialect = defaultDialect
            };
        }
    }
}
