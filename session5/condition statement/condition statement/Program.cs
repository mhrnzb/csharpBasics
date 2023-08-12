using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter Number: ");
            int NumberOfWeek = Convert.ToInt32(Console.ReadLine());
            //not a good solution
            if (NumberOfWeek == 1)
            {
                Console.WriteLine("Saturday");
            }
            else if (NumberOfWeek == 2)
            {
                Console.WriteLine("Sunday");
            }
            else if (NumberOfWeek == 3)
            {
                Console.WriteLine("Monday");
            }
            else if (NumberOfWeek == 4)
            {
                Console.WriteLine("Tuesday");
            }
            else if (NumberOfWeek == 5)
            {
                Console.WriteLine("Wednesday");
            }

            else if (NumberOfWeek == 6)
            {
                Console.WriteLine("Thursday");
            }

            else if (NumberOfWeek == 7)
            {
                Console.WriteLine("Friday");
            }
            
            //---------------------------------------------------------------------------------
            //good solution
            switch (NumberOfWeek)
            {
                case 1:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not found");
                        break;
                    }

            }







            Console.ReadKey();
        }
    }
}
