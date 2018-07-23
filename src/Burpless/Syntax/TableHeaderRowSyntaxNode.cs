namespace Burpless.Syntax
{
    public class TableHeaderRowSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTableHeaderRow(this);
        }
    }
}
