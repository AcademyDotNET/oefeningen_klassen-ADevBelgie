using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Nummers
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som()
        {
            return Getal1 + Getal2;
        }

        public int Verschil()
        {
            return Getal1 - Getal2;
        }

        public int Product()
        {
            return Getal1 * Getal2;
        }

        public int Quotient()
        {
           return Getal1/Getal2;
        }
    }
}
