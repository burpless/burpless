namespace Burpless.Configuration.Dialects
{
    internal class ChineseTraditionalDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Chinese traditional", "zh-TW")
                .Feature("功能")
                .Background("背景")
                .Scenario(x => x
                    .Scenario("場景", "劇本")
                    .ScenarioOutline("場景大綱", "劇本大綱")
                    .Examples("例子"))
                .Steps(x => x
                    .Given("假如", "假設", "假定")
                    .When("當")
                    .Then("那麼")
                    .And("而且", "並且", "同時")
                    .But("但是"))
                .Register();
        }
    }
}
