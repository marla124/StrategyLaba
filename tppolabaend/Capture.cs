using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppolabaend
{
    public class Capture : ICommandRobot
    {
        void ICommandRobot.Act()
        {
            Console.WriteLine("An object is being captured");
        }
    }
}
