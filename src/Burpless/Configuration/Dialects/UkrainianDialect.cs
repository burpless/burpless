namespace Burpless.Configuration.Dialects
{
    internal class UkrainianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Ukrainian", "uk")
                .Feature("Функціонал")
                .Background("Передумова")
                .Scenario(x => x
                    .Scenario("Сценарій")
                    .ScenarioOutline("Структура сценарію")
                    .Examples("Приклади"))
                .Steps(x => x
                    .Given("Припустимо", "Припустимо, що", "Нехай", "Дано")
                    .When("Якщо", "Коли")
                    .Then("То", "Тоді")
                    .And("І", "А також", "Та")
                    .But("Але"))
                .Register();
        }
    }
}
