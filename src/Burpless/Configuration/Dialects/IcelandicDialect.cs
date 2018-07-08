namespace Burpless.Configuration.Dialects
{
    internal class IcelandicDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Icelandic", "is")
                .Feature("Eiginleiki")
                .Background("Bakgrunnur")
                .Scenario(x => x
                    .Scenario("Atburðarás")
                    .ScenarioOutline("Lýsing Atburðarásar", "Lýsing Dæma")
                    .Examples("Dæmi", "Atburðarásir"))
                .Steps(x => x
                    .Given("Ef")
                    .When("Þegar")
                    .Then("Þá")
                    .And("Og")
                    .But("En"))
                .Register();
        }
    }
}
