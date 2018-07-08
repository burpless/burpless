namespace Burpless.Configuration.Dialects
{
    internal class CatalanDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Catalan", "ca")
                .Feature("Característica", "Funcionalitat")
                .Background("Rerefons", "Antecedents")
                .Scenario(x => x
                    .Scenario("Escenari")
                    .ScenarioOutline("Esquema de l&apos;escenari")
                    .Examples("Exemples"))
                .Steps(x => x
                    .Given("Donat", "Donada", "Atès", "Atesa")
                    .When("Quan")
                    .Then("Aleshores", "Cal")
                    .And("I")
                    .But("Però"))
                .Register();
        }
    }
}
