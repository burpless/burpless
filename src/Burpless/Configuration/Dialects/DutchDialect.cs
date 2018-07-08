namespace Burpless.Configuration.Dialects
{
    internal class DutchDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Dutch", "nl")
                .Feature("Functionaliteit")
                .Background("Achtergrond")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Abstract Scenario")
                    .Examples("Voorbeelden"))
                .Steps(x => x
                    .Given("Gegeven", "Stel")
                    .When("Als", "Wanneer")
                    .Then("Dan")
                    .And("En")
                    .But("Maar"))
                .Register();
        }
    }
}
