namespace Burpless.Configuration.Dialects
{
    internal class SpanishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Spanish", "es")
                .Feature("Característica")
                .Background("Antecedentes")
                .Scenario(x => x
                    .Scenario("Escenario")
                    .ScenarioOutline("Esquema del escenario")
                    .Examples("Ejemplos"))
                .Steps(x => x
                    .Given("Dado", "Dada", "Dados", "Dadas")
                    .When("Cuando")
                    .Then("Entonces")
                    .And("Y", "E")
                    .But("Pero"))
                .Register();
        }
    }
}
