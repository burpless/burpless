namespace Burpless.Configuration.Dialects
{
    internal class ThaiDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Thai", "th")
                .Feature("โครงหลัก", "ความต้องการทางธุรกิจ", "ความสามารถ")
                .Background("แนวคิด")
                .Scenario(x => x
                    .Scenario("เหตุการณ์")
                    .ScenarioOutline("สรุปเหตุการณ์", "โครงสร้างของเหตุการณ์")
                    .Examples("ชุดของตัวอย่าง", "ชุดของเหตุการณ์"))
                .Steps(x => x
                    .Given("กำหนดให้")
                    .When("เมื่อ")
                    .Then("ดังนั้น")
                    .And("และ")
                    .But("แต่"))
                .Register();
        }
    }
}
