using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mehrnaz = new MyClass();
            mehrnaz.name = "mehrnaz";
            mehrnaz.family = "family";

            MyClass.website = "GOOGLE.COM";

            int sum = mehrnaz.Sum(4 , 6 );

            Console.WriteLine(class1.SiteName);

            Console.WriteLine(class1.SiteURL);

            Console.ReadKey();



            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();
            MyClass m3 = new MyClass();
            MyClass m4 = new MyClass();
            MyClass m5 = new MyClass();

            Console.ReadKey();

        }
    }
}
