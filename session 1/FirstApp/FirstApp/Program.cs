using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world..");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("welcome to cSharp ");
            Console.ResetColor();   
            Console.ReadKey();
        }
    }
}
