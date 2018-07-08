namespace Burpless.Configuration.Dialects
{
    internal class PortugueseDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Portuguese", "pt")
                .Feature("Funcionalidade", "Característica", "Caracteristica")
                .Background("Contexto", "Cenário de Fundo", "Cenario de Fundo", "Fundo")
                .Scenario(x => x
                    .Scenario("Cenário", "Cenario")
                    .ScenarioOutline("Esquema do Cenário", "Esquema do Cenario", "Delineação do Cenário", "Delineacao do Cenario")
                    .Examples("Exemplos", "Cenários", "Cenarios"))
                .Steps(x => x
                    .Given("Dado", "Dada", "Dados", "Dadas")
                    .When("Quando")
                    .Then("Então", "Entao")
                    .And("E")
                    .But("Mas"))
                .Register();
        }
    }
}
