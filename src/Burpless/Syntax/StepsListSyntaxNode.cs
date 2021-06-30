using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class StepsListSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitStepsList(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
