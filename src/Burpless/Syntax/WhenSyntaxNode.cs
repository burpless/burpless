namespace Burpless.Syntax
{
    public class WhenSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitWhen(this);
        }
    }
}
