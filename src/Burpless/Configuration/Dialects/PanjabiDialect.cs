namespace Burpless.Configuration.Dialects
{
    internal class PanjabiDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Panjabi", "pa")
                .Feature("ਖਾਸੀਅਤ", "ਮੁਹਾਂਦਰਾ", "ਨਕਸ਼ ਨੁਹਾਰ")
                .Background("ਪਿਛੋਕੜ")
                .Scenario(x => x
                    .Scenario("ਪਟਕਥਾ")
                    .ScenarioOutline("ਪਟਕਥਾ ਢਾਂਚਾ", "ਪਟਕਥਾ ਰੂਪ ਰੇਖਾ")
                    .Examples("ਉਦਾਹਰਨਾਂ"))
                .Steps(x => x
                    .Given("ਜੇਕਰ", "ਜਿਵੇਂ ਕਿ")
                    .When("ਜਦੋਂ")
                    .Then("ਤਦ")
                    .And("ਅਤੇ")
                    .But("ਪਰ"))
                .Register();
        }
    }
}
