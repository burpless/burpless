namespace Burpless.Configuration.Dialects
{
    internal class UzbekDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Uzbek", "uz")
                .Feature("Функционал")
                .Background("Тарих")
                .Scenario(x => x
                    .Scenario("Сценарий")
                    .ScenarioOutline("Сценарий структураси")
                    .Examples("Мисоллар"))
                .Steps(x => x
                    .Given("Агар")
                    .When("Агар")
                    .Then("Унда")
                    .And("Ва")
                    .But("Лекин", "Бирок", "Аммо"))
                .Register();
        }
    }
}
