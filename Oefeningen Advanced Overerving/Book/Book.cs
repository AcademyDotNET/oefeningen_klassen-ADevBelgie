using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        private double _Price;
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }


    }
}
