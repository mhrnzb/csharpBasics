using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car pride = new Car();

            pride.Speed = 800;

            // if your property deos'nt have set , you can not assign anything !!!
            //pride.CarName = "peykan"; 




            Console.WriteLine($"car name is {pride.CarName}");

            Console.WriteLine($"speed is {pride.Speed}");
           

            Console.ReadKey();
            


        }
    }
}
