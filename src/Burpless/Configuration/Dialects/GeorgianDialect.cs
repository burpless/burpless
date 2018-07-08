namespace Burpless.Configuration.Dialects
{
    internal class GeorgianDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Georgian", "ka")
                .Feature("თვისება")
                .Background("კონტექსტი")
                .Scenario(x => x
                    .Scenario("სცენარის")
                    .ScenarioOutline("სცენარის ნიმუში")
                    .Examples("მაგალითები"))
                .Steps(x => x
                    .Given("მოცემული")
                    .When("როდესაც")
                    .Then("მაშინ")
                    .And("და")
                    .But("მაგ­რამ"))
                .Register();
        }
    }
}
