namespace Burpless.Configuration.Dialects
{
    internal class HindiDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Hindi", "hi")
                .Feature("रूप लेख")
                .Background("पृष्ठभूमि")
                .Scenario(x => x
                    .Scenario("परिदृश्य")
                    .ScenarioOutline("परिदृश्य रूपरेखा")
                    .Examples("उदाहरण"))
                .Steps(x => x
                    .Given("अगर", "यदि", "चूंकि")
                    .When("जब", "कदा")
                    .Then("तब", "तदा")
                    .And("और", "तथा")
                    .But("पर", "परन्तु", "किन्तु"))
                .Register();
        }
    }
}
