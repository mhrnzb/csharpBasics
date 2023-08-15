using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass_Example
{
    partial class MyClass
    {
        public int Sum (int a , int b)
        {
            return a + b; 
        }

        
    }


    partial class MyClass
    {
        public int Divide(int a , int b)
        {
            return a / b;
        }
    }

}
