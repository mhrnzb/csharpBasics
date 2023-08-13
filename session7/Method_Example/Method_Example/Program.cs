using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Mehrnaz";
            Console.WriteLine(Name.ToLower());
            
            //call method 
            
            SayHello();
            Console.ReadKey();

        }


        static void SayHello()
        {
            Console.WriteLine("Hello user");
        }


        static int sum(int a , int b)
        {
            return a + b;
        }
        
    }
}
