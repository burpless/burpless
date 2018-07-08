namespace Burpless.Configuration.Dialects
{
    internal class HebrewDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Hebrew", "he")
                .Feature("תכונה")
                .Background("רקע")
                .Scenario(x => x
                    .Scenario("תרחיש")
                    .ScenarioOutline("תבנית תרחיש")
                    .Examples("דוגמאות"))
                .Steps(x => x
                    .Given("בהינתן")
                    .When("כאשר")
                    .Then("אז", "אזי")
                    .And("וגם")
                    .But("אבל"))
                .Register();
        }
    }
}
