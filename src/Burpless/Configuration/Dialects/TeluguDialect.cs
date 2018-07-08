namespace Burpless.Configuration.Dialects
{
    internal class TeluguDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Telugu", "tl")
                .Feature("గుణము")
                .Background("నేపథ్యం")
                .Scenario(x => x
                    .Scenario("సన్నివేశం")
                    .ScenarioOutline("కథనం")
                    .Examples("ఉదాహరణలు"))
                .Steps(x => x
                    .Given("చెప్పబడినది")
                    .When("ఈ పరిస్థితిలో")
                    .Then("అప్పుడు")
                    .And("మరియు")
                    .But("కాని"))
                .Register();
        }
    }
}
