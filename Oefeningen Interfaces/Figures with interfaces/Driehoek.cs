using System;
using System.Collections.Generic;
using System.Text;

namespace Figures_with_interfaces
{
    class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return (int)(Breedte * Hoogte / 2);
        }
    }
}
