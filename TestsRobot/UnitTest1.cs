using System.Text;
using System.Text.Unicode;
using tppolabaend;


namespace TestsRobot
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Robot robot = new("Nivi 1095");
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            robot.Act();
            Assert.That(writer.ToString().Trim(), Is.EqualTo("Nivi 1095 ������ �� ������"));
        }

        [Test]
        public void Test2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Robot robot = new("Nivi 1095");
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            robot.SetCommandRobot(new Move());
            robot.Act();
            Assert.That(writer.ToString().Trim(), Is.EqualTo("Nivi 1095 ��������� ��������"));
        }
    }
}