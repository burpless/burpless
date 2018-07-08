namespace Burpless.Configuration.Dialects
{
    internal class LolcatDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("LOLCAT", "en-lol")
                .Feature("OH HAI")
                .Background("B4")
                .Scenario(x => x
                    .Scenario("MISHUN")
                    .ScenarioOutline("MISHUN SRSLY")
                    .Examples("EXAMPLZ"))
                .Steps(x => x
                    .Given("I CAN HAZ")
                    .When("WEN")
                    .Then("DEN")
                    .And("AN")
                    .But("BUT"))
                .Register();
        }
    }
}
