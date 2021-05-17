using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement, IMovable
    {
        SpeelVeld speelveld;
        public Monster(int x, int y, SpeelVeld speelveld) : base(x,y)
        {
            this.speelveld = speelveld;
            DitElementChar = SoortElementChar.M;
        }
        public void Move(int direction, GameManager gameManager)
        {
            switch (direction)
            {
                case 0: //up
                    speelveld.MoveElement(this, Location.X - 1, Location.Y);
                    break;
                case 1: //right
                    speelveld.MoveElement(this, Location.X, Location.Y + 1);
                    break;
                case 2: //down
                    speelveld.MoveElement(this, Location.X + 1, Location.Y);
                    break;
                case 3: //left
                    speelveld.MoveElement(this, Location.X, Location.Y - 1);
                    break;
                default:
                    break;
            }
        }
    }
}
