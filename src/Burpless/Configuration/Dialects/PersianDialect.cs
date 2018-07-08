namespace Burpless.Configuration.Dialects
{
    internal class PersianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Persian", "fa")
                .Feature("وِیژگی")
                .Background("زمینه")
                .Scenario(x => x
                    .Scenario("سناریو")
                    .ScenarioOutline("الگوی سناریو")
                    .Examples("نمونه ها"))
                .Steps(x => x
                    .Given("با فرض")
                    .When("هنگامی")
                    .Then("آنگاه")
                    .And("و")
                    .But("اما"))
                .Register();
        }
    }
}
