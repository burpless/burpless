namespace Burpless.Configuration.Dialects
{
    internal class SerbianLatinDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Serbian (Latin)", "sr-Latn")
                .Feature("Funkcionalnost", "Mogućnost", "Mogucnost", "Osobina")
                .Background("Kontekst", "Osnova", "Pozadina")
                .Scenario(x => x
                    .Scenario("Scenario", "Primer")
                    .ScenarioOutline("Struktura scenarija", "Skica", "Koncept")
                    .Examples("Primeri", "Scenariji"))
                .Steps(x => x
                    .Given("Za dato", "Za date", "Za dati")
                    .When("Kada", "Kad")
                    .Then("Onda")
                    .And("I")
                    .But("Ali"))
                .Register();
        }
    }
}
