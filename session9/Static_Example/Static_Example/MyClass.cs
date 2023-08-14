using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    internal class MyClass
    {

        public string name;
        public string family;

        public static string website;


    public int Sum(int a, int b)
    {
        return a + b;
    }

        public MyClass()
        {
            Console.WriteLine("Public constractor")
        }
        static MyClass()
        {
            Console.WriteLine("Static constractor");
        }
}
}

