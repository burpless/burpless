namespace Burpless.Syntax
{
    public class CommentSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitComment(this);
        }
    }
}
