using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_figures
{
    abstract class GeometricFigure
    {
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public abstract int BerekenOppervlakte();
    }
}
