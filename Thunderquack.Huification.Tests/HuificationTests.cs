namespace Thunderquack.Huification.Tests
{
    public class Tests
    {
       
        [Test]
        public void HuificationTest()
        {
            string simpleString = "я хочу кушать";
            Assert.That(simpleString.Huificate(), Is.EqualTo("хуюшать"));
            simpleString = "ясно";
            Assert.That(simpleString.Huificate(), Is.EqualTo("ху€сно"));
        }
    }
}