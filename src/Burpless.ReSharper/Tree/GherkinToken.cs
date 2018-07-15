using Burpless.ReSharper.Parsing;
using Burpless.ReSharper.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;

namespace Burpless.ReSharper.Tree
{
    public class GherkinToken : BindedToBufferLeafElement, ITokenNode
    {
        public GherkinToken(GherkinTokenNodeType nodeType, IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
            : base(nodeType, buffer, startOffset, endOffset)
        {
        }

        public override PsiLanguageType Language => GherkinLanguage.Instance;

        public TokenNodeType GetTokenType()
        {
            return (TokenNodeType) NodeType;
        }
    }
}
