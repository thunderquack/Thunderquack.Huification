namespace Thunderquack.Huification.Tests
{
    /// <summary>
    /// Tests for the huification.
    /// </summary>
    public class HuificationTests
    {
        /// <summary>
        /// Basic test.
        /// </summary>
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