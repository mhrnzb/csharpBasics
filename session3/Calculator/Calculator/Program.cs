using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1 :");
            string number1 = Console.ReadLine();

            Console.WriteLine("Please enter number 2 :");
            string number2 = Console.ReadLine();


            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);

            int sum = num1 + num2;
            Console.WriteLine("Sum is : " + sum);


            Console.ReadKey();
        }
    }
}
