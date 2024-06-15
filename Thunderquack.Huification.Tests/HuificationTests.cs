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
            string simpleString = "я хочу кушать";
            Assert.AreEqual("хуюшать", simpleString.Huificate());
            simpleString = "ясно";
            Assert.AreEqual("ху€сно", simpleString.Huificate());
        }
    }
}