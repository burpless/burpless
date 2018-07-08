namespace Burpless.Configuration.Dialects
{
    internal class DanishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Danish", "da")
                .Feature("Egenskab")
                .Background("Baggrund")
                .Scenario(x => x
                    .Scenario("Scenarie")
                    .ScenarioOutline("Abstrakt Scenario")
                    .Examples("Eksempler"))
                .Steps(x => x
                    .Given("Givet")
                    .When("Når")
                    .Then("Så")
                    .And("Og")
                    .But("Men"))
                .Register();
        }
    }
}
