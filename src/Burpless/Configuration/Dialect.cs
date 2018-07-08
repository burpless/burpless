using System;
using System.Collections.Generic;
using System.Linq;
using Burpless.Configuration.Dialects;

namespace Burpless.Configuration
{
    public class Dialect
    {
        private const string DefaultDialect = "en";

        private static readonly Dictionary<string, Dialect> Dialects = new Dictionary<string, Dialect>();

        static Dialect()
        {
            foreach (var dialect in GetInBuiltDialects())
                dialect.Register();
        }

        public Dialect(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new ArgumentException("Parameter cannot be null or empty", nameof(code));

            if (!Dialects.TryGetValue(code, out var dialect))
                throw new DialectNotFoundException("Dialect not found", nameof(code), code);

            Name = dialect.Name;
            Code = dialect.Code;
            Keywords = dialect.Keywords;
        }

        private Dialect(string name, string code, IDictionary<KeywordType, string[]> keywords)
        {
            Name = name;
            Code = code;
            Keywords = keywords;
        }

        public static Dialect Default => Dialects[DefaultDialect];

        public string Name { get; }

        public string Code { get; }

        private IDictionary<KeywordType, string[]> Keywords { get; }

        public static Dialect GetDialect(string code)
        {
            return new Dialect(code);
        }

        public static Dialect[] GetDialects()
        {
            return Dialects.Values.ToArray();
        }

        public string[] GetKeywords(KeywordType type)
        {
            if (!Keywords.TryGetValue(type, out var keywords))
                return Array.Empty<string>();

            return keywords.ToArray();
        }

        internal static void Register(string name, string code, IDictionary<KeywordType, string[]> keywords)
        {
            var dialect = new Dialect(name, code, keywords);

            Dialects.Add(dialect.Code, dialect);
        }

        private static IEnumerable<IDialect> GetInBuiltDialects()
        {
            yield return new AfrikaansDialect();
            yield return new ArmenianDialect();
            yield return new ArabicDialect();
            yield return new AsturianDialect();
            yield return new AzerbaijaniDialect();
            yield return new BulgarianDialect();
            yield return new MalayDialect();
            yield return new BosnianDialect();
            yield return new CatalanDialect();
            yield return new CzechDialect();
            yield return new WelshDialect();
            yield return new DanishDialect();
            yield return new GermanDialect();
            yield return new GreekDialect();
            yield return new EmojiDialect();
            yield return new EnglishDialect();
            yield return new ScouseDialect();
            yield return new AustralianDialect();
            yield return new LolcatDialect();
            yield return new OldEnglishDialect();
            yield return new PirateDialect();
            yield return new EsperantoDialect();
            yield return new SpanishDialect();
            yield return new EstonianDialect();
            yield return new PersianDialect();
            yield return new FinnishDialect();
            yield return new FrenchDialect();
            yield return new IrishDialect();
            yield return new GujaratiDialect();
            yield return new GalicianDialect();
            yield return new HebrewDialect();
            yield return new HindiDialect();
            yield return new CroatianDialect();
            yield return new CreoleDialect();
            yield return new HungarianDialect();
            yield return new IndonesianDialect();
            yield return new IcelandicDialect();
            yield return new ItalianDialect();
            yield return new JapaneseDialect();
            yield return new JavaneseDialect();
            yield return new GeorgianDialect();
            yield return new KannadaDialect();
            yield return new KoreanDialect();
            yield return new LithuanianDialect();
            yield return new LuxemburgishDialect();
            yield return new LatvianDialect();
            yield return new MacedonianDialect();
            yield return new MacedonianLatinDialect();
            yield return new MongolianDialect();
            yield return new DutchDialect();
            yield return new NorwegianDialect();
            yield return new PanjabiDialect();
            yield return new PolishDialect();
            yield return new PortugueseDialect();
            yield return new RomanianDialect();
            yield return new RussianDialect();
            yield return new SlovakDialect();
            yield return new SlovenianDialect();
            yield return new SerbianDialect();
            yield return new SerbianLatinDialect();
            yield return new SwedishDialect();
            yield return new TamilDialect();
            yield return new ThaiDialect();
            yield return new TeluguDialect();
            yield return new KlingonDialect();
            yield return new TurkishDialect();
            yield return new TatarDialect();
            yield return new UkrainianDialect();
            yield return new UrduDialect();
            yield return new UzbekDialect();
            yield return new VietnameseDialect();
            yield return new ChineseSimplifiedDialect();
            yield return new ChineseTraditionalDialect();
        }
    }
}
