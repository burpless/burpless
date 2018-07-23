namespace Burpless.Syntax
{
    public class TagSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTag(this);
        }
    }
}
