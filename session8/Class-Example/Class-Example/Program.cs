using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Class1.Sum(4, 5);
            Console.WriteLine(sum);
            Console.WriteLine(Class1.FullName("Mehrnaz" , "Bagheri"));
            Console.ReadKey();

        }
    }
}
