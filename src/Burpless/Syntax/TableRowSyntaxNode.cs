using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class TableRowSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTableRow(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
