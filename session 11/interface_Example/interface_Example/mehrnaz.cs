using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Example
{
    internal class mehrnaz : IMyinterface
    {
        public void ControlSpeed(int speed)
        {
            Console.WriteLine("Speed control");
        }


        public string HelloUser(string Name)
        {
            return "hello" + Name;
        }
    }
}
