namespace Burpless.Configuration.Dialects
{
    internal class GreekDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Greek", "el")
                .Feature("Δυνατότητα", "Λειτουργία")
                .Background("Υπόβαθρο")
                .Scenario(x => x
                    .Scenario("Σενάριο")
                    .ScenarioOutline("Περιγραφή Σεναρίου", "Περίγραμμα Σεναρίου")
                    .Examples("Παραδείγματα", "Σενάρια"))
                .Steps(x => x
                    .Given("Δεδομένου")
                    .When("Όταν")
                    .Then("Τότε")
                    .And("Και")
                    .But("Αλλά"))
                .Register();
        }
    }
}
