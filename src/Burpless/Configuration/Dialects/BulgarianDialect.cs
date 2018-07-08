namespace Burpless.Configuration.Dialects
{
    internal class BulgarianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Bulgarian", "bg")
                .Feature("Функционалност")
                .Background("Предистория")
                .Scenario(x => x
                    .Scenario("Сценарий")
                    .ScenarioOutline("Рамка на сценарий")
                    .Examples("Примери"))
                .Steps(x => x
                    .Given("Дадено")
                    .When("Когато")
                    .Then("То")
                    .And("И")
                    .But("Но"))
                .Register();
        }
    }
}
