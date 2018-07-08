namespace Burpless.Configuration.Dialects
{
    internal class FinnishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Finnish", "fi")
                .Feature("Ominaisuus")
                .Background("Tausta")
                .Scenario(x => x
                    .Scenario("Tapaus")
                    .ScenarioOutline("Tapausaihio")
                    .Examples("Tapaukset"))
                .Steps(x => x
                    .Given("Oletetaan")
                    .When("Kun")
                    .Then("Niin")
                    .And("Ja")
                    .But("Mutta"))
                .Register();
        }
    }
}
