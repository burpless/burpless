namespace Burpless.Configuration.Dialects
{
    internal class AsturianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Asturian", "ast")
                .Feature("Carauterística")
                .Background("Antecedentes")
                .Scenario(x => x
                    .Scenario("Casu")
                    .ScenarioOutline("Esbozu del casu")
                    .Examples("Exemplos"))
                .Steps(x => x
                    .Given("Dáu", "Dada", "Daos", "Daes")
                    .When("Cuando")
                    .Then("Entós")
                    .And("Y", "Ya")
                    .But("Peru"))
                .Register();
        }
    }
}
