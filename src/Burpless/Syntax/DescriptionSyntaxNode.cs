namespace Burpless.Syntax
{
    public class DescriptionSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitDescription(this);
        }
    }
}
