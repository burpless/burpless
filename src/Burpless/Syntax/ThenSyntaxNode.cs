using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class ThenSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitThen(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
