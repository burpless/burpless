namespace Burpless.Configuration.Dialects
{
    internal class AustralianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Australian", "en-au")
                .Feature("Pretty much")
                .Background("First off")
                .Scenario(x => x
                    .Scenario("Awww, look mate")
                    .ScenarioOutline("Reckon it&apos;s like")
                    .Examples("You&apos;ll wanna"))
                .Steps(x => x
                    .Given("Y&apos;know")
                    .When("It&apos;s just unbelievable")
                    .Then("But at the end of the day I reckon")
                    .And("Too right")
                    .But("Yeah nah"))
                .Register();
        }
    }
}
