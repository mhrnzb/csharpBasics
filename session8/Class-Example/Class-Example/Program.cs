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





            Console.WriteLine("*******************************************");

            Console.WriteLine("please enter personal number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Person[]  people = new Person[number];

            for (int i =0; i < number; i++)
            {
                Console.WriteLine($"please enter person[{i+1}] name : ");
                string name = Console.ReadLine();



                Console.WriteLine($"please enter person[{i + 1}] family : ");
                string family = Console.ReadLine();

                Console.WriteLine($"please enter person[{i + 1}] website : ");
                string website = Console.ReadLine();

                Person p = new Person(name , family, website);
                people[i] = p;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach(Person person in people)
            {


                Console.WriteLine($"name :{person.Name} Family :{person.Family} website : {person.website}");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
