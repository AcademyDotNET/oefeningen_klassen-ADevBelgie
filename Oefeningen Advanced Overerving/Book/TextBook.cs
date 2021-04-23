using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class TextBook: Book
    {
        public int GradeLevel { get; set; }

        public override double Price
        {
            get { return _Price; }
            //a) Bij Textbook de prijs enkel tussen 20 en 80 kan liggen 
            set 
            {
                if (value <= 80 && value >= 20 )
                {
                    _Price = value;
                }
                else if(value < 20)
                {
                    _Price = 20;
                }
                else
                {
                    _Price = 80;
                }
            }
        }
    }
}
