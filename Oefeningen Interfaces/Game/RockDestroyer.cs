using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RockDestroyer : Monster, IDestroyer
    {
        public RockDestroyer(int x, int y) : base(x, y)
        {
            DitElement = SoortElement.RockDestroyer;
            DitElementChar = SoortElementChar.X;
        }

        public void ShootLeft(SpeelVeld speelveld)
        {
            //naar links schieten 
            speelveld.Destroy(Location.X, Location.Y - 1); //X is rows, Y is Cols
        }

        public void ShootRight(SpeelVeld speelveld)
        {
            //naar rechts schieten 
            speelveld.Destroy(Location.X, Location.Y + 1);
        }
    }
}
