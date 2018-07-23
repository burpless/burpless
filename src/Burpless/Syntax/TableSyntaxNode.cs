namespace Burpless.Syntax
{
    public class TableSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTable(this);
        }
    }
}
