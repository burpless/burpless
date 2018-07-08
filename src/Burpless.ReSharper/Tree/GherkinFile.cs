using Burpless.ReSharper.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace Burpless.ReSharper.Tree
{
    public class GherkinFile : FileElementBase
    {
        public override NodeType NodeType => GherkinNodeType.GherkinFile;

        public override PsiLanguageType Language => GherkinLanguage.Instance;
    }
}
