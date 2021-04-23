using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_figures
{
    class Vierkant : Rechthoek
    {
        public Vierkant()
        {
        }
        public Vierkant(double lengte , double breedte)
        {
            Hoogte = lengte;
            Breedte = lengte;
        }
        public Vierkant(double lengte)
        {
            Hoogte = lengte;
            Breedte = lengte;
        }
        public override int BerekenOppervlakte()
        {
            Hoogte = Breedte;
            return base.BerekenOppervlakte();
        }
    }
}
