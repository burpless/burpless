namespace Burpless.Configuration.Dialects
{
    internal class CreoleDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Creole", "ht")
                .Feature("Karakteristik", "Mak", "Fonksyonalite")
                .Background("Kontèks", "Istorik")
                .Scenario(x => x
                    .Scenario("Senaryo")
                    .ScenarioOutline("Plan senaryo", "Plan Senaryo", "Senaryo deskripsyon", "Senaryo Deskripsyon", "Dyagram senaryo", "Dyagram Senaryo")
                    .Examples("Egzanp"))
                .Steps(x => x
                    .Given("Sipoze", "Sipoze ke", "Sipoze Ke")
                    .When("Lè", "Le")
                    .Then("Lè sa a", "Le sa a")
                    .And("Ak", "Epi", "E")
                    .But("Men"))
                .Register();
        }
    }
}
