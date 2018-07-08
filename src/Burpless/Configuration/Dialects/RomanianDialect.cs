namespace Burpless.Configuration.Dialects
{
    internal class RomanianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Romanian", "ro")
                .Feature("Functionalitate", "Funcționalitate", "Funcţionalitate")
                .Background("Context")
                .Scenario(x => x
                    .Scenario("Scenariu")
                    .ScenarioOutline("Structura scenariu", "Structură scenariu")
                    .Examples("Exemple"))
                .Steps(x => x
                    .Given("Date fiind", "Dat fiind", "Dată fiind", "Dati fiind", "Dați fiind", "Daţi fiind")
                    .When("Cand", "Când")
                    .Then("Atunci")
                    .And("Si", "Și", "Şi")
                    .But("Dar"))
                .Register();
        }
    }
}
