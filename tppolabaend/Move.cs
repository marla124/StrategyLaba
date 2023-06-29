using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppolabaend
{
    public class Move : ICommandRobot
    {
        void ICommandRobot.Act()
        {
            Console.WriteLine("Makes a move");
        }
    }
}
