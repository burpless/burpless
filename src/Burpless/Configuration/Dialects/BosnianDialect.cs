namespace Burpless.Configuration.Dialects
{
    internal class BosnianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Bosnian", "bs")
                .Feature("Karakteristika")
                .Background("Pozadina")
                .Scenario(x => x
                    .Scenario("Scenariju", "Scenario")
                    .ScenarioOutline("Scenariju-obris", "Scenario-outline")
                    .Examples("Primjeri"))
                .Steps(x => x
                    .Given("Dato")
                    .When("Kada")
                    .Then("Zatim")
                    .And("I", "A")
                    .But("Ali"))
                .Register();
        }
    }
}
