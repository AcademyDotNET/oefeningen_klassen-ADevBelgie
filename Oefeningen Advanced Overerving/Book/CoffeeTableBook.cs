using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class CoffeeTableBook: Book
    {
        public override double Price
        {
            get { return _Price; }
            //b) Bij CoffeeTableBooks de prijs enkel tussen 35 en 100 kan liggen
            set
            {
                if (value <= 100 && value >= 35)
                {
                    _Price = value;
                }
                else if (value < 35)
                {
                    _Price = 35;
                }
                else
                {
                    _Price = 100;
                }
            }
        }
    }
}
