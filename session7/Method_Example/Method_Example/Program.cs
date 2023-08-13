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
            int sum = Sum(20, 10);
            Console.WriteLine(sum);
            Console.ReadKey();

        }


        static void SayHello()
        {
            Console.WriteLine("Hello user");
        }


        static int Sum(int a , int b)
        {
            return a + b;
        }
        
    }
}
