using Thunderquack.Huification;
namespace Thunderquack.Huification.Tests
{
    public class Tests
    {
        string simpleString;

        [SetUp]
        public void Setup()
        {
            simpleString = "� ���� ������";
        }

        [Test]
        public void CyrillicTest()
        {
            Assert.Pass();
        }

        [Test]
        public void SplitWordsTest()
        {
            Assert.Pass();
        }
        
        [Test]
        public void HuificationTest()
        {
            Assert.That(simpleString.Huificate(), Is.EqualTo("�������")); 
        }
    }
}