namespace Burpless.Configuration.Dialects
{
    internal class EmojiDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Emoji", "em")
                .Feature("📚")
                .Background("💤")
                .Scenario(x => x
                    .Scenario("📕")
                    .ScenarioOutline("📖")
                    .Examples("📓"))
                .Steps(x => x
                    .Given("😐")
                    .When("🎬")
                    .Then("🙏")
                    .And("😂")
                    .But("😔"))
                .Register();
        }
    }
}
