namespace Burpless.Configuration.Dialects
{
    internal class AzerbaijaniDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Azerbaijani", "az")
                .Feature("Özəllik")
                .Background("Keçmiş", "Kontekst")
                .Scenario(x => x
                    .Scenario("Ssenari")
                    .ScenarioOutline("Ssenarinin strukturu")
                    .Examples("Nümunələr"))
                .Steps(x => x
                    .Given("Tutaq ki", "Verilir")
                    .When("Əgər", "Nə vaxt ki")
                    .Then("O halda")
                    .And("Və", "Həm")
                    .But("Amma", "Ancaq"))
                .Register();
        }
    }
}
