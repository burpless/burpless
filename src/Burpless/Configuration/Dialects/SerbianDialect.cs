namespace Burpless.Configuration.Dialects
{
    internal class SerbianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Serbian", "sr-Cyrl")
                .Feature("Функционалност", "Могућност", "Особина")
                .Background("Контекст", "Основа", "Позадина")
                .Scenario(x => x
                    .Scenario("Сценарио", "Пример")
                    .ScenarioOutline("Структура сценарија", "Скица", "Концепт")
                    .Examples("Примери", "Сценарији"))
                .Steps(x => x
                    .Given("За дато", "За дате", "За дати")
                    .When("Када", "Кад")
                    .Then("Онда")
                    .And("И")
                    .But("Али"))
                .Register();
        }
    }
}
