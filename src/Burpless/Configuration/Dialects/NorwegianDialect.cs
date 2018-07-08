namespace Burpless.Configuration.Dialects
{
    internal class NorwegianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Norwegian", "no")
                .Feature("Egenskap")
                .Background("Bakgrunn")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Scenariomal", "Abstrakt Scenario")
                    .Examples("Eksempler"))
                .Steps(x => x
                    .Given("Gitt")
                    .When("Når")
                    .Then("Så")
                    .And("Og")
                    .But("Men"))
                .Register();
        }
    }
}
