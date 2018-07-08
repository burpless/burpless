namespace Burpless.Configuration.Dialects
{
    internal class LuxemburgishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Luxemburgish", "lu")
                .Feature("Funktionalitéit")
                .Background("Hannergrond")
                .Scenario(x => x
                    .Scenario("Szenario")
                    .ScenarioOutline("Plang vum Szenario")
                    .Examples("Beispiller"))
                .Steps(x => x
                    .Given("ugeholl")
                    .When("wann")
                    .Then("dann")
                    .And("an", "a")
                    .But("awer", "mä"))
                .Register();
        }
    }
}
