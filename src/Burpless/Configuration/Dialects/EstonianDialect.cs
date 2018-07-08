namespace Burpless.Configuration.Dialects
{
    internal class EstonianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Estonian", "et")
                .Feature("Omadus")
                .Background("Taust")
                .Scenario(x => x
                    .Scenario("Stsenaarium")
                    .ScenarioOutline("Raamstsenaarium")
                    .Examples("Juhtumid"))
                .Steps(x => x
                    .Given("Eeldades")
                    .When("Kui")
                    .Then("Siis")
                    .And("Ja")
                    .But("Kuid"))
                .Register();
        }
    }
}
