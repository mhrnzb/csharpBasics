using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {




            try
            {
                Console.WriteLine("please enter person number : ");

                int number = Convert.ToInt32(Console.ReadLine());

                string[] Names = new string[number];

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("please enter name" + (i + 1));
                    Names[i] = Console.ReadLine();
                }
                Console.ReadKey();





            }
            catch
            {
                Console.WriteLine("please enter just number ...");
            }




            
        }
    }
}
