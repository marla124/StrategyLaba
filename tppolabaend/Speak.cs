using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppolabaend
{
    public class Speak : ICommandRobot
    {
        void ICommandRobot.Act()
        {
            Console.WriteLine("Произносит заготовленную речь");
        }
    }
}
