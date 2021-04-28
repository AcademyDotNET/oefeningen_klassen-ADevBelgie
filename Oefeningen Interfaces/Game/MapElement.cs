using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    enum SoortElement { Player, Monster, Leeg, Rock}
    enum SoortElementChar { P, M, L, R }

    abstract class MapElement
    {
        public SoortElement DitElement { get; set; } // Player, Monster, leeg, Rots
        public SoortElementChar DitElementChar { get; set; } // Player, Monster, leeg, Rots
    }
}
