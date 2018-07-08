namespace Burpless.Configuration.Dialects
{
    internal class SlovakDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Slovak", "sk")
                .Feature("Požiadavka", "Funkcia", "Vlastnosť")
                .Background("Pozadie")
                .Scenario(x => x
                    .Scenario("Scenár")
                    .ScenarioOutline("Náčrt Scenáru", "Náčrt Scenára", "Osnova Scenára")
                    .Examples("Príklady"))
                .Steps(x => x
                    .Given("Pokiaľ", "Za predpokladu")
                    .When("Keď", "Ak")
                    .Then("Tak", "Potom")
                    .And("A", "A tiež", "A taktiež", "A zároveň")
                    .But("Ale"))
                .Register();
        }
    }
}
