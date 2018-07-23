namespace Burpless.Syntax
{
    public class ThenSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitThen(this);
        }
    }
}
