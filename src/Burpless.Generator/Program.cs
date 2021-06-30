using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace Burpless.Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var code = new StringBuilder()
                .AppendLine("namespace Burpless.Configuration.Dialects")
                .Append("{");

            var method = new StringBuilder();

            var languages = GetLanguages()
                .ToArray();
            
            foreach (var language in languages)
            {
                var className = GetLanguageName(language.Name);

                code.AppendLine($@"
    internal class {className}Dialect : IDialect
    {{
        public void Register()
        {{
            DialectBuilder.Create({language.Name.AsQuoted()}, {language.Code.AsQuoted()})
                .Feature({language.Keywords[KeywordType.Feature].JoinQuoted(", ")})
                .Background({language.Keywords[KeywordType.Background].JoinQuoted(", ")})
                .Scenario(x => x
                    .Scenario({language.Keywords[KeywordType.Scenario].JoinQuoted(", ")})
                    .ScenarioOutline({language.Keywords[KeywordType.ScenarioOutline].JoinQuoted(", ")})
                    .Examples({language.Keywords[KeywordType.Examples].JoinQuoted(", ")}))
                .Steps(x => x
                    .Given({language.Keywords[KeywordType.Given].JoinQuoted(", ")})
                    .When({language.Keywords[KeywordType.When].JoinQuoted(", ")})
                    .Then({language.Keywords[KeywordType.Then].JoinQuoted(", ")})
                    .And({language.Keywords[KeywordType.And].JoinQuoted(", ")})
                    .But({language.Keywords[KeywordType.But].JoinQuoted(", ")}))
                .Register();
        }}
    }}");
            }

            code.AppendLine("}");

            foreach (var language in languages)
                method.AppendLine($"yield return new {GetLanguageName(language.Name)}Dialect();");

            Console.WriteLine(code.ToString());
            Console.WriteLine(method.ToString());
        }

        private static string GetLanguageName(string language)
        {
            return language
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace(" ", String.Empty)
                .Replace("LOLCAT", "Lolcat")
                .Replace("simplified", "Simplified")
                .Replace("traditional", "Traditional")
                .Trim();
        }

        private static IEnumerable<Language> GetLanguages()
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://docs.cucumber.io/gherkin/reference/");

            var rows = doc.DocumentNode.SelectNodes("//table/tbody/tr");

            foreach (var row in rows)
            {
                var languageName = row.SelectNodes("td")
                    .First()
                    .InnerText;

                var index = languageName.LastIndexOf('(');

                var language = languageName.Substring(0, index).Trim();
                var code = languageName.Substring(index + 1, languageName.Length - index - 2).Trim();

                var keywords = new Dictionary<KeywordType, string[]>();

                var keywordNodes = row.SelectNodes("td")
                    .Skip(1)
                    .ToArray();

                for (var i = 0; i < keywordNodes.Length; i++)
                {
                    var node = keywordNodes[i];
                    var words = node.SelectNodes("code")
                        .Select(x => x.InnerText.Trim())
                        .Where(x => x != "*")
                        .ToArray();

                    if (i == 0)
                        keywords[KeywordType.Feature] = words;
                    else if (i == 1)
                        keywords[KeywordType.Background] = words;
                    else if (i == 2)
                        keywords[KeywordType.Scenario] = words;
                    else if (i == 3)
                        keywords[KeywordType.ScenarioOutline] = words;
                    else if (i == 4)
                        keywords[KeywordType.Examples] = words;
                    else if (i == 5)
                        keywords[KeywordType.Given] = words;
                    else if (i == 6)
                        keywords[KeywordType.When] = words;
                    else if (i == 7)
                        keywords[KeywordType.Then] = words;
                    else if (i == 8)
                        keywords[KeywordType.And] = words;
                    else if (i == 9)
                        keywords[KeywordType.But] = words;
                }

                yield return new Language(language, code, keywords);
            }
        }
    }
}
