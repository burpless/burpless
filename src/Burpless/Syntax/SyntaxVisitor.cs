namespace Burpless.Syntax
{
    public class SyntaxVisitor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public virtual void Visit(SyntaxNode node)
        {
        }

        public virtual void VisitComment(CommentSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitDescription(DescriptionSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitFeature(FeatureSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitBackground(BackgroundSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitScenario(ScenarioSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitScenarioOutline(ScenarioOutlineSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitExamples(ExamplesSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitStepsList(StepsListSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitGiven(GivenSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitWhen(WhenSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitThen(ThenSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitTagList(TagListSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitTag(TagSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitString(StringSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitTable(TableSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitTableHeaderRow(TableHeaderRowSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitTableRow(TableRowSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitDocString(DocStringSyntaxNode node)
        {
            node.Accept(this);
        }
    }
}
