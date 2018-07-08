namespace Burpless.Configuration.Dialects
{
    internal class GermanDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("German", "de")
                .Feature("Funktionalität")
                .Background("Grundlage")
                .Scenario(x => x
                    .Scenario("Szenario")
                    .ScenarioOutline("Szenariogrundriss")
                    .Examples("Beispiele"))
                .Steps(x => x
                    .Given("Angenommen", "Gegeben sei", "Gegeben seien")
                    .When("Wenn")
                    .Then("Dann")
                    .And("Und")
                    .But("Aber"))
                .Register();
        }
    }
}
