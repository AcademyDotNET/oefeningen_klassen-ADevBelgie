using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Rock : MapElement
    {
        public Rock(int x, int y) : base(x, y)
        {
            DitElement = SoortElement.Rock;
            DitElementChar = SoortElementChar.R;
        }
    }
}
