namespace Burpless.Configuration.Dialects
{
    internal class OldEnglishDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Old English", "en-old")
                .Feature("Hwaet", "Hwæt")
                .Background("Aer", "Ær")
                .Scenario(x => x
                    .Scenario("Swa")
                    .ScenarioOutline("Swa hwaer swa", "Swa hwær swa")
                    .Examples("Se the", "Se þe", "Se ðe"))
                .Steps(x => x
                    .Given("Thurh", "Þurh", "Ðurh")
                    .When("Tha", "Þa", "Ða")
                    .Then("Tha", "Þa", "Ða", "Tha the", "Þa þe", "Ða ðe")
                    .And("Ond", "7")
                    .But("Ac"))
                .Register();
        }
    }
}
