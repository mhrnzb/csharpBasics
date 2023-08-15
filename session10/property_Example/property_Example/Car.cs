using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_Example
{
    internal class Car
    {

        private int _speed;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("danger speed");
                    _speed = 0;

                }
                else
                {
                    _speed = value;
                }

            }
        }

        private string _CarName = "pride";

        public string CarName
        {
            get
            {
                return _CarName;
            }

            
        }
        

    }
}
