using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5 };
            string[] names = new string[3];

            List<int> Nums = new List<int>();

            // to add an element
            Nums.Add(5);
            Nums.Add(6);
            Nums.Add(7);
            Nums.Add(8);

            // to remove an element 
            Nums.Remove(6);

            // to remove an element by using index
            Nums.RemoveAt(0);


            List<string> Names = new List<string>();

            Names.Add("mehrnaz");
            Names.Add("faezeh");
            Names.Add("sara");


            foreach(string I  in Names)
            {
                Console.WriteLine($"name is : {I}");
            }

            Console.ReadKey();
        }
    }
}
