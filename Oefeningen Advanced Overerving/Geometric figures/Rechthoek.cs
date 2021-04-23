using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_figures
{
    class Rechthoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return (int)(Breedte * Hoogte);
        }
    }
}
