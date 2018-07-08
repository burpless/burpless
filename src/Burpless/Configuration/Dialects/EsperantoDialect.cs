namespace Burpless.Configuration.Dialects
{
    internal class EsperantoDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Esperanto", "eo")
                .Feature("Trajto")
                .Background("Fono")
                .Scenario(x => x
                    .Scenario("Scenaro", "Kazo")
                    .ScenarioOutline("Konturo de la scenaro", "Skizo", "Kazo-skizo")
                    .Examples("Ekzemploj"))
                .Steps(x => x
                    .Given("Donitaĵo", "Komence")
                    .When("Se")
                    .Then("Do")
                    .And("Kaj")
                    .But("Sed"))
                .Register();
        }
    }
}
