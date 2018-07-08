namespace Burpless.Configuration.Dialects
{
    internal class ArabicDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Arabic", "ar")
                .Feature("خاصية")
                .Background("الخلفية")
                .Scenario(x => x
                    .Scenario("سيناريو")
                    .ScenarioOutline("سيناريو مخطط")
                    .Examples("امثلة"))
                .Steps(x => x
                    .Given("بفرض")
                    .When("متى", "عندما")
                    .Then("اذاً", "ثم")
                    .And("و")
                    .But("لكن"))
                .Register();
        }
    }
}
