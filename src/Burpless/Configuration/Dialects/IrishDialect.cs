namespace Burpless.Configuration.Dialects
{
    internal class IrishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Irish", "ga")
                .Feature("Gné")
                .Background("Cúlra")
                .Scenario(x => x
                    .Scenario("Cás")
                    .ScenarioOutline("Cás Achomair")
                    .Examples("Samplaí"))
                .Steps(x => x
                    .Given("Cuir i gcás go", "Cuir i gcás nach", "Cuir i gcás gur", "Cuir i gcás nár")
                    .When("Nuair a", "Nuair nach", "Nuair ba", "Nuair nár")
                    .Then("Ansin")
                    .And("Agus")
                    .But("Ach"))
                .Register();
        }
    }
}
