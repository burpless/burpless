namespace Burpless.Configuration.Dialects
{
    internal class ItalianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Italian", "it")
                .Feature("Funzionalità")
                .Background("Contesto")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Schema dello scenario")
                    .Examples("Esempi"))
                .Steps(x => x
                    .Given("Dato", "Data", "Dati", "Date")
                    .When("Quando")
                    .Then("Allora")
                    .And("E")
                    .But("Ma"))
                .Register();
        }
    }
}
