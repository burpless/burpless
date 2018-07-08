namespace Burpless.Configuration.Dialects
{
    internal class CroatianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Croatian", "hr")
                .Feature("Osobina", "Mogućnost", "Mogucnost")
                .Background("Pozadina")
                .Scenario(x => x
                    .Scenario("Scenarij")
                    .ScenarioOutline("Skica", "Koncept")
                    .Examples("Primjeri", "Scenariji"))
                .Steps(x => x
                    .Given("Zadan", "Zadani", "Zadano")
                    .When("Kada", "Kad")
                    .Then("Onda")
                    .And("I")
                    .But("Ali"))
                .Register();
        }
    }
}
