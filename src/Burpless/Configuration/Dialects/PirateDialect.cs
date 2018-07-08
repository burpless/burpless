namespace Burpless.Configuration.Dialects
{
    internal class PirateDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Pirate", "en-pirate")
                .Feature("Ahoy matey!")
                .Background("Yo-ho-ho")
                .Scenario(x => x
                    .Scenario("Heave to")
                    .ScenarioOutline("Shiver me timbers")
                    .Examples("Dead men tell no tales"))
                .Steps(x => x
                    .Given("Gangway!")
                    .When("Blimey!")
                    .Then("Let go and haul")
                    .And("Aye")
                    .But("Avast!"))
                .Register();
        }
    }
}
