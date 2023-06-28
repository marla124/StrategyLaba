using NUnit.Framework;
using tppolabaend;


[TestFixture]
public class Tests
{
    [Test]
    public void TestRobotActWithoutCommand()
    {
        Robot robot = new Robot("Nivi 1095");
        string expectedOutput = "Nivi 1095 ничего не делает";

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            robot.Act();
            string actualOutput = sw.ToString().Trim();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }

    [Test]
    public void TestRobotActWithMoveCommand()
    {
        Robot robot = new Robot("Nivi 1095");
        robot.SetCommandRobot(new Move());
        string expectedOutput = "Nivi 1095 Совершает движение";

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            robot.Act();
            string actualOutput = sw.ToString().Trim();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
