namespace Thunderquack.Huification.Tests
{
    public class Tests
    {
       
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