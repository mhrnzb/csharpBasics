using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mehrnaz me = new mehrnaz();

            Console.WriteLine(me.HelloUser("mehrnaz bagheri"));

            HiUser hi = new HiUser();
            Console.WriteLine(hi.HelloUser("mehrnaz BAGHERI"));



            IMyinterface i1 = new mehrnaz();
            IMyinterface i2 = new HiUser();


            List<Person> people = new List<Person>();

            Person p1 = new Person();
            p1.Name = "mehrnaz";
            p1.Family = "Bagheri";
            p1.Age = 20;

            people.Add(p1);


            Person p2 = new Person();
            p1.Name = "fateme";
            p1.Family = "fatemi";
            p1.Age = 30;

            people.Add(p2);

            foreach(Person p  in people)
            {
                Console.WriteLine($"name : {p.Name} family : {p.Family} age : {p.Age}");
            }


            //IEnumerable<Person> list = new List<Person>();


            Console.ReadKey(); 
        }
    }
}
