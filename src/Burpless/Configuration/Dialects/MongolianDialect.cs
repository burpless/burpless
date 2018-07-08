namespace Burpless.Configuration.Dialects
{
    internal class MongolianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Mongolian", "mn")
                .Feature("Функц", "Функционал")
                .Background("Агуулга")
                .Scenario(x => x
                    .Scenario("Сценар")
                    .ScenarioOutline("Сценарын төлөвлөгөө")
                    .Examples("Тухайлбал"))
                .Steps(x => x
                    .Given("Өгөгдсөн нь", "Анх")
                    .When("Хэрэв")
                    .Then("Тэгэхэд", "Үүний дараа")
                    .And("Мөн", "Тэгээд")
                    .But("Гэхдээ", "Харин"))
                .Register();
        }
    }
}
