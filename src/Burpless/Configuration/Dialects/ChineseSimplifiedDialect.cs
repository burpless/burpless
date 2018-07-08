namespace Burpless.Configuration.Dialects
{
    internal class ChineseSimplifiedDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Chinese simplified", "zh-CN")
                .Feature("功能")
                .Background("背景")
                .Scenario(x => x
                    .Scenario("场景", "剧本")
                    .ScenarioOutline("场景大纲", "剧本大纲")
                    .Examples("例子"))
                .Steps(x => x
                    .Given("假如", "假设", "假定")
                    .When("当")
                    .Then("那么")
                    .And("而且", "并且", "同时")
                    .But("但是"))
                .Register();
        }
    }
}
