using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Console.WriteLine(my.Sum(2, 5));
            
            Console.ReadKey();
        }
    }
}
