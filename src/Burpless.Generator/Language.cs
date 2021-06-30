using System.Collections.Generic;

namespace Burpless.Generator
{
    public class Language
    {
        public Language(string name, string code, IReadOnlyDictionary<KeywordType, string[]> keywords)
        {
            Name = name;
            Code = code;
            Keywords = keywords;
        }

        public string Name { get; }

        public string Code { get; }

        public IReadOnlyDictionary<KeywordType, string[]> Keywords { get; }
    }
}
