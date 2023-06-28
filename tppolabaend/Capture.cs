using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppolabaend
{
    internal class Capture : ICommandRobot
    {
        void ICommandRobot.Act()
        {
            Console.WriteLine("Происходит захват предмета");
        }
    }
}
