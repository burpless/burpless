namespace Burpless.Configuration.Dialects
{
    internal class KlingonDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Klingon", "tlh")
                .Feature("Qap", "Qu&apos;meH &apos;ut", "perbogh", "poQbogh malja&apos;", "laH")
                .Background("mo&apos;")
                .Scenario(x => x
                    .Scenario("lut")
                    .ScenarioOutline("lut chovnatlh")
                    .Examples("ghantoH", "lutmey"))
                .Steps(x => x
                    .Given("ghu&apos; noblu&apos;", "DaH ghu&apos; bejlu&apos;")
                    .When("qaSDI&apos;")
                    .Then("vaj")
                    .And("&apos;ej", "latlh")
                    .But("&apos;ach", "&apos;a"))
                .Register();
        }
    }
}
