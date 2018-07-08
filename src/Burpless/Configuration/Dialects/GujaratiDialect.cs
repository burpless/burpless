namespace Burpless.Configuration.Dialects
{
    internal class GujaratiDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Gujarati", "gj")
                .Feature("લક્ષણ", "વ્યાપાર જરૂર", "ક્ષમતા")
                .Background("બેકગ્રાઉન્ડ")
                .Scenario(x => x
                    .Scenario("સ્થિતિ")
                    .ScenarioOutline("પરિદ્દશ્ય રૂપરેખા", "પરિદ્દશ્ય ઢાંચો")
                    .Examples("ઉદાહરણો"))
                .Steps(x => x
                    .Given("આપેલ છે")
                    .When("ક્યારે")
                    .Then("પછી")
                    .And("અને")
                    .But("પણ"))
                .Register();
        }
    }
}
