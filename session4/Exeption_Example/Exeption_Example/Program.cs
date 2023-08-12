using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("please enter number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is" + num1 + num2);
            Console.ReadKey();
        }
    }
}
