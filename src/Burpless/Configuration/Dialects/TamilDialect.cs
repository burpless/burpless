namespace Burpless.Configuration.Dialects
{
    internal class TamilDialect : IDialect
    {
        public void Register()
        {
            DialectBuilder.Create("Tamil", "ta")
                .Feature("அம்சம்", "வணிக தேவை", "திறன்")
                .Background("பின்னணி")
                .Scenario(x => x
                    .Scenario("காட்சி")
                    .ScenarioOutline("காட்சி சுருக்கம்", "காட்சி வார்ப்புரு")
                    .Examples("எடுத்துக்காட்டுகள்", "காட்சிகள்", "நிலைமைகளில்"))
                .Steps(x => x
                    .Given("கொடுக்கப்பட்ட")
                    .When("எப்போது")
                    .Then("அப்பொழுது")
                    .And("மேலும்", "மற்றும்")
                    .But("ஆனால்"))
                .Register();
        }
    }
}
