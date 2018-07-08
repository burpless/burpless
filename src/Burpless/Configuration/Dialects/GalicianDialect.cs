namespace Burpless.Configuration.Dialects
{
    internal class GalicianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Galician", "gl")
                .Feature("Característica")
                .Background("Contexto")
                .Scenario(x => x
                    .Scenario("Escenario")
                    .ScenarioOutline("Esbozo do escenario")
                    .Examples("Exemplos"))
                .Steps(x => x
                    .Given("Dado", "Dada", "Dados", "Dadas")
                    .When("Cando")
                    .Then("Entón", "Logo")
                    .And("E")
                    .But("Mais", "Pero"))
                .Register();
        }
    }
}
