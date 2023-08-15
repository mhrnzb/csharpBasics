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
            int num1 = 0;
            int num2 = 0;



            try
            {
            Console.WriteLine("please enter number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            }

            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter just number.");
                Console.ResetColor();
            }
            catch 
            {
                Console.WriteLine("un expected error");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            

            Console.WriteLine("Sum is" + (num1 + num2));

            Console.ReadKey();
        }
    }
}
