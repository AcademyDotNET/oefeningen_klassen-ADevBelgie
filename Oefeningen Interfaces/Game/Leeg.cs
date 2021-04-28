using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Leeg : MapElement
    {
        public Leeg()
        {
            DitElement = SoortElement.Leeg;
            DitElementChar = SoortElementChar.L;
        }
    }
}
