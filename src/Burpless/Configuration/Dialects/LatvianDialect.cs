namespace Burpless.Configuration.Dialects
{
    internal class LatvianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Latvian", "lv")
                .Feature("Funkcionalitāte", "Fīča")
                .Background("Konteksts", "Situācija")
                .Scenario(x => x
                    .Scenario("Scenārijs")
                    .ScenarioOutline("Scenārijs pēc parauga")
                    .Examples("Piemēri", "Paraugs"))
                .Steps(x => x
                    .Given("Kad")
                    .When("Ja")
                    .Then("Tad")
                    .And("Un")
                    .But("Bet"))
                .Register();
        }
    }
}
