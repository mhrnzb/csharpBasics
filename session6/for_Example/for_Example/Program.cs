using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {   //infinity loop
            for (int i = 0; i<20; )
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
