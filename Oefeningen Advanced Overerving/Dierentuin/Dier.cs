using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    abstract class Dier
    {
        public double Gewicht { get; set; }
        public abstract void Zegt();
    }
}
