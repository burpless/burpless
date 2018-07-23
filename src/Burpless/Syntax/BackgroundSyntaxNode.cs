namespace Burpless.Syntax
{
    public class BackgroundSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitBackground(this);
        }
    }
}
