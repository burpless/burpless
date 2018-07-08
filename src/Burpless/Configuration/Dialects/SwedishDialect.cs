namespace Burpless.Configuration.Dialects
{
    internal class SwedishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Swedish", "sv")
                .Feature("Egenskap")
                .Background("Bakgrund")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Abstrakt Scenario", "Scenariomall")
                    .Examples("Exempel"))
                .Steps(x => x
                    .Given("Givet")
                    .When("När")
                    .Then("Så")
                    .And("Och")
                    .But("Men"))
                .Register();
        }
    }
}
