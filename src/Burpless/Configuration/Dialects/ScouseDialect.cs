namespace Burpless.Configuration.Dialects
{
    internal class ScouseDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Scouse", "en-Scouse")
                .Feature("Feature")
                .Background("Dis is what went down")
                .Scenario(x => x
                    .Scenario("The thing of it is")
                    .ScenarioOutline("Wharrimean is")
                    .Examples("Examples"))
                .Steps(x => x
                    .Given("Givun", "Youse know when youse got")
                    .When("Wun", "Youse know like when")
                    .Then("Dun", "Den youse gotta")
                    .And("An")
                    .But("Buh"))
                .Register();
        }
    }
}
