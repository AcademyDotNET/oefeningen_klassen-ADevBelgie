using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player:MapElement, IMovable, IDestroyer
    {
        public Player(int x, int y) : base(x, y)
        {
            DitElement = SoortElement.Player;
            DitElementChar = SoortElementChar.P;
        }
        public void Shoot(SpeelVeld speelveld)
        {
            //naar rechts schieten 
            speelveld.Destroy(Location.X, Location.Y);
        }
        public void MoveUp()
        {

        }
        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveRight()
        {

        }
    }
}
