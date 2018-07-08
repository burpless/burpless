namespace Burpless.Configuration.Dialects
{
    internal class JavaneseDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Javanese", "jv")
                .Feature("Fitur")
                .Background("Dasar")
                .Scenario(x => x
                    .Scenario("Skenario")
                    .ScenarioOutline("Konsep skenario")
                    .Examples("Conto", "Contone"))
                .Steps(x => x
                    .Given("Nalika", "Nalikaning")
                    .When("Manawa", "Menawa")
                    .Then("Njuk", "Banjur")
                    .And("Lan")
                    .But("Tapi", "Nanging", "Ananging"))
                .Register();
        }
    }
}
