namespace Burpless.Configuration.Dialects
{
    internal class PolishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Polish", "pl")
                .Feature("Właściwość", "Funkcja", "Aspekt", "Potrzeba biznesowa")
                .Background("Założenia")
                .Scenario(x => x
                    .Scenario("Scenariusz")
                    .ScenarioOutline("Szablon scenariusza")
                    .Examples("Przykłady"))
                .Steps(x => x
                    .Given("Zakładając", "Mając", "Zakładając, że")
                    .When("Jeżeli", "Jeśli", "Gdy", "Kiedy")
                    .Then("Wtedy")
                    .And("Oraz", "I")
                    .But("Ale"))
                .Register();
        }
    }
}
