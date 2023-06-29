using tppolabaend;


namespace TestsRobot
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Robot robot = new("Nivi 1095");
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            robot.Act();
            Assert.That(writer.ToString().Trim(), Is.EqualTo("Nivi 1095 ничего не делает"));
        }

        [Test]
        public void Test2()
        {
            Robot robot = new("Nivi 1095");
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            robot.SetCommandRobot(new Move());
            robot.Act();
            Assert.That(writer.ToString().Trim(), Is.EqualTo("Nivi 1095 Совершает движение"));
        }
    }
}