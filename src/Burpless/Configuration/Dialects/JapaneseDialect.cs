namespace Burpless.Configuration.Dialects
{
    internal class JapaneseDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Japanese", "ja")
                .Feature("フィーチャ", "機能")
                .Background("背景")
                .Scenario(x => x
                    .Scenario("シナリオ")
                    .ScenarioOutline("シナリオアウトライン", "シナリオテンプレート", "テンプレ", "シナリオテンプレ")
                    .Examples("例", "サンプル"))
                .Steps(x => x
                    .Given("前提")
                    .When("もし")
                    .Then("ならば")
                    .And("かつ")
                    .But("しかし", "但し", "ただし"))
                .Register();
        }
    }
}
