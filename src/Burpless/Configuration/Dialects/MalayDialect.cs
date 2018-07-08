namespace Burpless.Configuration.Dialects
{
    internal class MalayDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Malay", "bm")
                .Feature("Fungsi")
                .Background("Latar Belakang")
                .Scenario(x => x
                    .Scenario("Senario", "Situasi", "Keadaan")
                    .ScenarioOutline("Kerangka Senario", "Kerangka Situasi", "Kerangka Keadaan", "Garis Panduan Senario")
                    .Examples("Contoh"))
                .Steps(x => x
                    .Given("Diberi", "Bagi")
                    .When("Apabila")
                    .Then("Maka", "Kemudian")
                    .And("Dan")
                    .But("Tetapi", "Tapi"))
                .Register();
        }
    }
}
