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
            car1.carSpeed = 100;
            car1.carModel = "1400";


            Car car2 = new Car();
            car2.carName = "Peykan";
            car2.carSpeed = 80;
            car2.carModel = "1388";


            Console.WriteLine(car1.carName +" " + car1.carSpeed + " " + car1.carModel );
            Console.WriteLine(car2.carName + " " + car2.carSpeed + " " + car2.carModel);



            Person p1 = new Person("Mehrnaz" , "bagheri" , "nothing");


            Console.WriteLine($"name :{p1.Name} Family :{p1.Family} website : {p1.website}" );
        }
    }
}
