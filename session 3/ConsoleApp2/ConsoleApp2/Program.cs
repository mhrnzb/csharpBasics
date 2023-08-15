using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            string test = Convert.ToString(a);

            

            string num1 = "123456";

            int num = Convert.ToInt32(num1);

            num = num + 123;
            // num++;
            // num--;
            //num +=3;

            bool isActive = Convert.ToBoolean("True");
            
            Console.WriteLine(test);
            Console.WriteLine(num);
            Console.ReadKey();


        }
    }
}
