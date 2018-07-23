namespace Burpless.Syntax
{
    public class DocStringSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitDocString(this);
        }
    }
}
