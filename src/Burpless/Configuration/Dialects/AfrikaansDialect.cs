namespace Burpless.Configuration.Dialects
{
    internal class AfrikaansDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Afrikaans", "af")
                .Feature("Funksie", "Besigheid Behoefte", "Vermoë")
                .Background("Agtergrond")
                .Scenario(x => x
                    .Scenario("Situasie")
                    .ScenarioOutline("Situasie Uiteensetting")
                    .Examples("Voorbeelde"))
                .Steps(x => x
                    .Given("Gegewe")
                    .When("Wanneer")
                    .Then("Dan")
                    .And("En")
                    .But("Maar"))
                .Register();
        }
    }
}
