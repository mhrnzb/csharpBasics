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
        {
            string Name = "name 1";
            //string Name = "name 2";    // it means you can not have variable with same name
            string nAme = "name 3";    // CSharp is case sensitive.
            Console.WriteLine(Name);
            Console.WriteLine(nAme);
            Console.ReadKey();

        }
    }

    public class test2
    {
        //we cant see name here.
        // we can access the variable only in the specified block.
        string Name = "sara ";

        //here you can use  Name variable .
    }
}
