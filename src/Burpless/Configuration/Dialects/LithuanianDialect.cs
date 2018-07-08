namespace Burpless.Configuration.Dialects
{
    internal class LithuanianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Lithuanian", "lt")
                .Feature("Savybė")
                .Background("Kontekstas")
                .Scenario(x => x
                    .Scenario("Scenarijus")
                    .ScenarioOutline("Scenarijaus šablonas")
                    .Examples("Pavyzdžiai", "Scenarijai", "Variantai"))
                .Steps(x => x
                    .Given("Duota")
                    .When("Kai")
                    .Then("Tada")
                    .And("Ir")
                    .But("Bet"))
                .Register();
        }
    }
}
