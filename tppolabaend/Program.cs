using System;

namespace tppolabaend
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new("Nivi 1095");
            robot.Act();

            robot.SetCommandRobot(new Move());
            robot.Act();
        }
    }

}