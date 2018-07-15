using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.UI.Icons;

namespace Burpless.ReSharper.Psi
{
    [ProjectFileType(typeof(GherkinProjectFileType))]
    public class GherkinProjectFileLanguageService : ProjectFileLanguageService
    {
        public GherkinProjectFileLanguageService(GherkinProjectFileType projectFileType)
            : base(projectFileType)
        {
        }

        protected override PsiLanguageType PsiLanguageType => GherkinLanguage.Instance;

        public override IconId Icon => null;

        public override ILexerFactory GetMixedLexerFactory(ISolution solution, IBuffer buffer, IPsiSourceFile sourceFile = null)
        {
            var service = GherkinLanguage.Instance.LanguageService();

            return service?.GetPrimaryLexerFactory();
        }
    }
}
