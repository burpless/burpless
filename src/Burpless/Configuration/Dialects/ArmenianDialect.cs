namespace Burpless.Configuration.Dialects
{
    internal class ArmenianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Armenian", "am")
                .Feature("Ֆունկցիոնալություն", "Հատկություն")
                .Background("Կոնտեքստ")
                .Scenario(x => x
                    .Scenario("Սցենար")
                    .ScenarioOutline("Սցենարի կառուցվացքը")
                    .Examples("Օրինակներ"))
                .Steps(x => x
                    .Given("Դիցուք")
                    .When("Եթե", "Երբ")
                    .Then("Ապա")
                    .And("Եվ")
                    .But("Բայց"))
                .Register();
        }
    }
}
