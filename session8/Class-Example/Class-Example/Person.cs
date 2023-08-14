using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    internal class Person
    {

        public string Name;
        public string Family;
        public string website;



        public Person(string name, string family, string website)
        {
            // به سطح کلاس اشاره میکند نه به متد های سازندهthis 
            this.Name = name;
            this.Family = family;   
            this.website = website; 
            

        }
    }
}
