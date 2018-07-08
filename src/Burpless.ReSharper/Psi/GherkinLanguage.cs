using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;

namespace Burpless.ReSharper.Psi
{
    [LanguageDefinition(Name)]
    public class GherkinLanguage : KnownLanguage
    {
        public new const string Name = "GHERKIN";

        public new const string PresentableName = "Gherkin";

        [UsedImplicitly(ImplicitUseKindFlags.Assign)]
        public static GherkinLanguage Instance;

        public GherkinLanguage()
            : base(Name, PresentableName)
        {
        }
    }
}
