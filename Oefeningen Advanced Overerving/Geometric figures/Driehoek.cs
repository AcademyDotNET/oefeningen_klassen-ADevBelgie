using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_figures
{
    class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return (int)(Breedte * Hoogte / 2);
        }
    }
}
