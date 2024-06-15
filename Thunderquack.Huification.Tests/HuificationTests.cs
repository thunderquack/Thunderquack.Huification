using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Thunderquack.Huification.Tests
{
    /// <summary>
    /// Tests for the huification.
    /// </summary>
    [TestClass]
    public class HuificationTests
    {
        /// <summary>
        /// Basic test.
        /// </summary>
        [TestMethod]
        public void HuificationTest()
        {
            string simpleString = "Я хочу кушать";
            Assert.AreEqual("хуюшать", simpleString.Huificate());
            simpleString = "Ясно";
            Assert.AreEqual("хуясно", simpleString.Huificate());
        }
    }
}