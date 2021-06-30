using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class GivenSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitGiven(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
