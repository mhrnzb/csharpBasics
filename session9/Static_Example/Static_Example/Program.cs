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
        }
    }
}
