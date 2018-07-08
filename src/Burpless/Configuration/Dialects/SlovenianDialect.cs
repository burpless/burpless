namespace Burpless.Configuration.Dialects
{
    internal class SlovenianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Slovenian", "sl")
                .Feature("Funkcionalnost", "Funkcija", "Možnosti", "Moznosti", "Lastnost", "Značilnost")
                .Background("Kontekst", "Osnova", "Ozadje")
                .Scenario(x => x
                    .Scenario("Scenarij", "Primer")
                    .ScenarioOutline("Struktura scenarija", "Skica", "Koncept", "Oris scenarija", "Osnutek")
                    .Examples("Primeri", "Scenariji"))
                .Steps(x => x
                    .Given("Dano", "Podano", "Zaradi", "Privzeto")
                    .When("Ko", "Ce", "Če", "Kadar")
                    .Then("Nato", "Potem", "Takrat")
                    .And("In", "Ter")
                    .But("Toda", "Ampak", "Vendar"))
                .Register();
        }
    }
}
