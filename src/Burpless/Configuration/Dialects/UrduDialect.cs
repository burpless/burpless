namespace Burpless.Configuration.Dialects
{
    internal class UrduDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Urdu", "ur")
                .Feature("صلاحیت", "کاروبار کی ضرورت", "خصوصیت")
                .Background("پس منظر")
                .Scenario(x => x
                    .Scenario("منظرنامہ")
                    .ScenarioOutline("منظر نامے کا خاکہ")
                    .Examples("مثالیں"))
                .Steps(x => x
                    .Given("اگر", "بالفرض", "فرض کیا")
                    .When("جب")
                    .Then("پھر", "تب")
                    .And("اور")
                    .But("لیکن"))
                .Register();
        }
    }
}
