namespace Burpless.Configuration.Dialects
{
    internal class MacedonianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Macedonian", "mk-Cyrl")
                .Feature("Функционалност", "Бизнис потреба", "Можност")
                .Background("Контекст", "Содржина")
                .Scenario(x => x
                    .Scenario("Сценарио", "На пример")
                    .ScenarioOutline("Преглед на сценарија", "Скица", "Концепт")
                    .Examples("Примери", "Сценарија"))
                .Steps(x => x
                    .Given("Дадено", "Дадена")
                    .When("Кога")
                    .Then("Тогаш")
                    .And("И")
                    .But("Но"))
                .Register();
        }
    }
}
