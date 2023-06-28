using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppolabaend
{
    internal class Robot
    {
        private readonly string _model;
        private ICommandRobot? _commandRobot;

        public Robot(string model)
        {
            _model = model;
        }

        public void SetCommandRobot(ICommandRobot commandRobot)
        {
            _commandRobot = commandRobot;
        }
        public void Act() 
        {
            if (_commandRobot is null)
            {
                Console.WriteLine($"{_model} ничего не делает");
            }
            else
            {
                Console.WriteLine($"{_model} ");
                _commandRobot.Act();
            }
        }
    }
}
