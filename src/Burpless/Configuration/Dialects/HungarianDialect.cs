namespace Burpless.Configuration.Dialects
{
    internal class HungarianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Hungarian", "hu")
                .Feature("Jellemző")
                .Background("Háttér")
                .Scenario(x => x
                    .Scenario("Forgatókönyv")
                    .ScenarioOutline("Forgatókönyv vázlat")
                    .Examples("Példák"))
                .Steps(x => x
                    .Given("Amennyiben", "Adott")
                    .When("Majd", "Ha", "Amikor")
                    .Then("Akkor")
                    .And("És")
                    .But("De"))
                .Register();
        }
    }
}
