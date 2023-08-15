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
            string family = "";
            Console.WriteLine("please enter name : ");

            name = Console.ReadLine();
            name = name.ToLower();

            Console.WriteLine("please enter family name : ");

            family = Console.ReadLine();
            family = family.ToLower();

            if (name == "mehrnaz" && family =="bagheri")
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
