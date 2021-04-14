using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Driehoek
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }

        public void ToonOppervlakte()
        {
            Console.WriteLine( $"oppervlakte driehoek: {(Basis * Hoogte) /2}" );
            return;
        }
    }
}
