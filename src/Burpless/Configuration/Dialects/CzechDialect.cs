namespace Burpless.Configuration.Dialects
{
    internal class CzechDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Czech", "cs")
                .Feature("Požadavek")
                .Background("Pozadí", "Kontext")
                .Scenario(x => x
                    .Scenario("Scénář")
                    .ScenarioOutline("Náčrt Scénáře", "Osnova scénáře")
                    .Examples("Příklady"))
                .Steps(x => x
                    .Given("Pokud", "Za předpokladu")
                    .When("Když")
                    .Then("Pak")
                    .And("A také", "A")
                    .But("Ale"))
                .Register();
        }
    }
}
