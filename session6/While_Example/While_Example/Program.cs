using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //infinite loop

            //while(true)
            //{
            //    Console.WriteLine("hello there!");
            //}



            int i = 0;
            while (i < 20)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
