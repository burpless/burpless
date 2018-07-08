namespace Burpless.Configuration.Dialects
{
    internal class RussianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Russian", "ru")
                .Feature("Функция", "Функциональность", "Функционал", "Свойство")
                .Background("Предыстория", "Контекст")
                .Scenario(x => x
                    .Scenario("Сценарий")
                    .ScenarioOutline("Структура сценария")
                    .Examples("Примеры"))
                .Steps(x => x
                    .Given("Допустим", "Дано", "Пусть", "Если")
                    .When("Когда")
                    .Then("То", "Затем", "Тогда")
                    .And("И", "К тому же", "Также")
                    .But("Но", "А"))
                .Register();
        }
    }
}
