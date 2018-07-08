namespace Burpless.Configuration.Dialects
{
    internal class TurkishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Turkish", "tr")
                .Feature("Özellik")
                .Background("Geçmiş")
                .Scenario(x => x
                    .Scenario("Senaryo")
                    .ScenarioOutline("Senaryo taslağı")
                    .Examples("Örnekler"))
                .Steps(x => x
                    .Given("Diyelim ki")
                    .When("Eğer ki")
                    .Then("O zaman")
                    .And("Ve")
                    .But("Fakat", "Ama"))
                .Register();
        }
    }
}
