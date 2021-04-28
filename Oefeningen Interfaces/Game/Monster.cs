using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement
    {
        public Monster()
        {
            DitElement = SoortElement.Monster;
            DitElementChar = SoortElementChar.M;
        }
    }
}
