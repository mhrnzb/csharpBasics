using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==
            //!=
            //>
            //<
            //>=
            //<=
            string name = "";
            Console.WriteLine("please enter name : ");
            name = Console.ReadLine();
            name = name.ToLower();
            if (name == "mehrnaz")
            {
                Console.WriteLine("hello mehrnaz");
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("hello user");
            }
            Console.ReadKey();
        }
    }
}
