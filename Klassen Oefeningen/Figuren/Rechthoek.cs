using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Rechthoek
    {
        int _lengte;
        int _breedte;

        public int Lengte
        {
            get { return _lengte; }
            set { _lengte = Math.Max(value, 1); }
        }
        public int Breedte
        {
            get { return _breedte; }
            set { _breedte = Math.Max(value, 1); }
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"oppervlakte rechthoek: {_lengte *_breedte}");
            return;
        }
    }
}
