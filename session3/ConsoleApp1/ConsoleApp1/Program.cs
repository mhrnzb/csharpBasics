using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Data types

            //INTEGER
            int a;
            a = 10;


            int b, c;
            b = 20;
            c= a + b;

            //STRING
            string name = "Mehrnaz ";
            string FamilyName = "Bagheri";
            string FullName = name + FamilyName;
            string age = "20";

            //BOOLEAN
            bool IsActive = true;   // use for conditions 

            // DOUBLE --> float numbers
            double price = 2.500;



            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
