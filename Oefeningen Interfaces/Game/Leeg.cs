using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Leeg : MapElement
    {
        public Leeg(int x, int y) : base(x, y)
        {
            DitElement = SoortElement.Leeg;
            DitElementChar = SoortElementChar.L;
        }
    }
}
