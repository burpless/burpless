namespace Burpless.Configuration.Dialects
{
    internal class EnglishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("English", "en")
                .Feature("Feature", "Business Need", "Ability")
                .Background("Background")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Scenario Outline", "Scenario Template")
                    .Examples("Examples", "Scenarios"))
                .Steps(x => x
                    .Given("Given")
                    .When("When")
                    .Then("Then")
                    .And("And")
                    .But("But"))
                .Register();
        }
    }
}
