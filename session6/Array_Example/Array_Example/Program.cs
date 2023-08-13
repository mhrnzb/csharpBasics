using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 , 4 };

            int number = numbers[2];

            string[] Names = {"name1" , "name2" , "name3" };

            for (int i=0;  i<3; i++)
            {
                Console.WriteLine(Names[i]);

            }

            Console.ReadKey();
        }
    }
}
