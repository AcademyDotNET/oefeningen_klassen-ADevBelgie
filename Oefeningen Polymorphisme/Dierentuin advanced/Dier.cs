using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin_advanced
{
    abstract class Dier
    {
        public double Gewicht { get; set; }
        public abstract void Zegt();
    }
}
