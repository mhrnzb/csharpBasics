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


            Car car1 = new Car();
            car1.carName = "Pride";
            car1.carSpeed = "100";
            car1.carModel = "1400";




        }
    }
}
