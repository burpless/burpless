namespace Burpless.Syntax
{
    public class SyntaxVisitor
    {
        public virtual void Visit(SyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual void VisitComment(CommentSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitDescription(DescriptionSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitFeature(FeatureSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitBackground(BackgroundSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitScenariosList(ScenariosListSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitScenario(ScenarioSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitScenarioOutline(ScenarioOutlineSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitExamples(ExamplesSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitStepsList(StepsListSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitGiven(GivenSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitWhen(WhenSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitThen(ThenSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitTagList(TagListSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitTag(TagSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitString(StringSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitTable(TableSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitTableHeaderRow(TableHeaderRowSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitTableRow(TableRowSyntaxNode node)
        {
            VisitChildren(node);
        }

        public virtual void VisitDocString(DocStringSyntaxNode node)
        {
            VisitChildren(node);
        }

        private void VisitChildren(SyntaxNode node)
        {
            foreach (var child in node.GetNodes())
                Visit(child);
        }
    }
}
