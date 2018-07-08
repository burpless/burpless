namespace Burpless.Configuration.Dialects
{
    internal class KoreanDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Korean", "ko")
                .Feature("기능")
                .Background("배경")
                .Scenario(x => x
                    .Scenario("시나리오")
                    .ScenarioOutline("시나리오 개요")
                    .Examples("예"))
                .Steps(x => x
                    .Given("조건", "먼저")
                    .When("만일", "만약")
                    .Then("그러면")
                    .And("그리고")
                    .But("하지만", "단"))
                .Register();
        }
    }
}
