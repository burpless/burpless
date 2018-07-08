namespace Burpless.Configuration.Dialects
{
    internal class IndonesianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Indonesian", "id")
                .Feature("Fitur")
                .Background("Dasar")
                .Scenario(x => x
                    .Scenario("Skenario")
                    .ScenarioOutline("Skenario konsep")
                    .Examples("Contoh"))
                .Steps(x => x
                    .Given("Dengan")
                    .When("Ketika")
                    .Then("Maka")
                    .And("Dan")
                    .But("Tapi"))
                .Register();
        }
    }
}
