using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player:MapElement
    {
        public Player(int x, int y) : base(x, y)
        {
            DitElement = SoortElement.Player;
            DitElementChar = SoortElementChar.P;
        }
    }
}
