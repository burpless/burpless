namespace Burpless.Configuration.Dialects
{
    internal class WelshDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Welsh", "cy-GB")
                .Feature("Arwedd")
                .Background("Cefndir")
                .Scenario(x => x
                    .Scenario("Scenario")
                    .ScenarioOutline("Scenario Amlinellol")
                    .Examples("Enghreifftiau"))
                .Steps(x => x
                    .Given("Anrhegedig a")
                    .When("Pryd")
                    .Then("Yna")
                    .And("A")
                    .But("Ond"))
                .Register();
        }
    }
}
