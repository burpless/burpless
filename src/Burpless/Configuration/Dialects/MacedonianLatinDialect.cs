namespace Burpless.Configuration.Dialects
{
    internal class MacedonianLatinDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Macedonian (Latin)", "mk-Latn")
                .Feature("Funkcionalnost", "Biznis potreba", "Mozhnost")
                .Background("Kontekst", "Sodrzhina")
                .Scenario(x => x
                    .Scenario("Scenario", "Na primer")
                    .ScenarioOutline("Pregled na scenarija", "Skica", "Koncept")
                    .Examples("Primeri", "Scenaria"))
                .Steps(x => x
                    .Given("Dadeno", "Dadena")
                    .When("Koga")
                    .Then("Togash")
                    .And("I")
                    .But("No"))
                .Register();
        }
    }
}
