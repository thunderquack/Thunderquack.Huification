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
            string simpleString = "� ���� ������";
            Assert.That(simpleString.Huificate(), Is.EqualTo("�������"));
            simpleString = "����";
            Assert.That(simpleString.Huificate(), Is.EqualTo("������"));
        }
    }
}