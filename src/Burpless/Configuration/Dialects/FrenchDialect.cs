namespace Burpless.Configuration.Dialects
{
    internal class FrenchDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("French", "fr")
                .Feature("Fonctionnalité")
                .Background("Contexte")
                .Scenario(x => x
                    .Scenario("Scénario")
                    .ScenarioOutline("Plan du scénario", "Plan du Scénario")
                    .Examples("Exemples"))
                .Steps(x => x
                    .Given("Soit", "Etant donné que", "Etant donné qu&apos;", "Etant donné", "Etant donnée", "Etant donnés", "Etant données", "Étant donné que", "Étant donné qu&apos;", "Étant donné", "Étant donnée", "Étant donnés", "Étant données")
                    .When("Quand", "Lorsque", "Lorsqu&apos;")
                    .Then("Alors")
                    .And("Et que", "Et qu&apos;", "Et")
                    .But("Mais que", "Mais qu&apos;", "Mais"))
                .Register();
        }
    }
}
