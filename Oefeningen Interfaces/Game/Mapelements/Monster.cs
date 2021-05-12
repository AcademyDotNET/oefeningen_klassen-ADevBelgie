using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement, IMovable
    {
        public Monster(int x, int y) : base(x,y)
        {
            DitElementChar = SoortElementChar.M;
        }
        public void MoveUp(SpeelVeld speelveld)
        {
            if (Location.X != 0 && speelveld.Array[Location.X - 1, Location.Y] is Leeg)
            {
                speelveld.Array[Location.X - 1, Location.Y] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.X--;
            }
        }
        public void Move(int direction, SpeelVeld speelveld, GameManager gameManager)
        {
            switch (direction)
            {
                case 0: //up
                    speelveld.MoveElement(this, Location.X - 1, Location.Y, gameManager);
                    break;
                case 1: //right
                    speelveld.MoveElement(this, Location.X, Location.Y + 1, gameManager);
                    break;
                case 2: //down
                    speelveld.MoveElement(this, Location.X + 1, Location.Y, gameManager);
                    break;
                case 3: //left
                    speelveld.MoveElement(this, Location.X, Location.Y - 1, gameManager);
                    break;
                default:
                    break;
            }
        }
    }
}
