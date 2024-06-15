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
            simpleString = "Парабола";
            Assert.AreEqual("хуябола", simpleString.Huificate());
        }

        /// <summary>
        /// Empty strings test.
        /// </summary>
        [TestMethod]
        public void EmptystringTest()
        {
            string simpleString = string.Empty;
            Assert.AreEqual(string.Empty, simpleString.Huificate());
            simpleString = "Кол";
            Assert.AreEqual(string.Empty, simpleString.Huificate());
            simpleString = "\n";
            Assert.AreEqual(string.Empty, simpleString.Huificate());
        }
    }
}