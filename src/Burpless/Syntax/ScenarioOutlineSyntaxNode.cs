using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class ScenarioOutlineSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitScenarioOutline(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
