namespace Burpless.Syntax
{
    public class TableRowSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTableRow(this);
        }
    }
}
