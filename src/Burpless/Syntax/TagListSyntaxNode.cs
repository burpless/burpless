namespace Burpless.Syntax
{
    public class TagListSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitTagList(this);
        }
    }
}
