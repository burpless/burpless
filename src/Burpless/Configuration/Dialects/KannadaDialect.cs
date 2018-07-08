namespace Burpless.Configuration.Dialects
{
    internal class KannadaDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Kannada", "kn")
                .Feature("ಹೆಚ್ಚಳ")
                .Background("ಹಿನ್ನೆಲೆ")
                .Scenario(x => x
                    .Scenario("ಕಥಾಸಾರಾಂಶ")
                    .ScenarioOutline("ವಿವರಣೆ")
                    .Examples("ಉದಾಹರಣೆಗಳು"))
                .Steps(x => x
                    .Given("ನೀಡಿದ")
                    .When("ಸ್ಥಿತಿಯನ್ನು")
                    .Then("ನಂತರ")
                    .And("ಮತ್ತು")
                    .But("ಆದರೆ"))
                .Register();
        }
    }
}
