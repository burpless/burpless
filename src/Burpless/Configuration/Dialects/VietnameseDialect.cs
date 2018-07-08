namespace Burpless.Configuration.Dialects
{
    internal class VietnameseDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Vietnamese", "vi")
                .Feature("Tính năng")
                .Background("Bối cảnh")
                .Scenario(x => x
                    .Scenario("Tình huống", "Kịch bản")
                    .ScenarioOutline("Khung tình huống", "Khung kịch bản")
                    .Examples("Dữ liệu"))
                .Steps(x => x
                    .Given("Biết", "Cho")
                    .When("Khi")
                    .Then("Thì")
                    .And("Và")
                    .But("Nhưng"))
                .Register();
        }
    }
}
