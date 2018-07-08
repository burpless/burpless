namespace Burpless.Configuration.Dialects
{
    internal class TatarDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Tatar", "tt")
                .Feature("Мөмкинлек", "Үзенчәлеклелек")
                .Background("Кереш")
                .Scenario(x => x
                    .Scenario("Сценарий")
                    .ScenarioOutline("Сценарийның төзелеше")
                    .Examples("Үрнәкләр", "Мисаллар"))
                .Steps(x => x
                    .Given("Әйтик")
                    .When("Әгәр")
                    .Then("Нәтиҗәдә")
                    .And("Һәм", "Вә")
                    .But("Ләкин", "Әмма"))
                .Register();
        }
    }
}
