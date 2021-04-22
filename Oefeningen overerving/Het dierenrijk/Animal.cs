using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Animal
    {
        public Animal()
        {
            AverageCellcountAdult = 1;
        }
        public int AverageCellcountAdult { get; set; }

        virtual public void ToonInfo()
        {
            Console.WriteLine($"AverageCellcountAdult: {AverageCellcountAdult}");
        }

    }
}
