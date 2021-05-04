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
            DitElement = SoortElement.Monster;
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
        public void MoveDown(SpeelVeld speelveld)
        {
            if (Location.X != 19 && speelveld.Array[Location.X + 1, Location.Y] is Leeg)
            {
                speelveld.Array[Location.X + 1, Location.Y] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.X++;
            }
        }
        public void MoveLeft(SpeelVeld speelveld)
        {
            if (Location.Y != 0 && speelveld.Array[Location.X, Location.Y - 1] is Leeg)
            {
                speelveld.Array[Location.X, Location.Y - 1] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.Y--;
            }
        }
        public void MoveRight(SpeelVeld speelveld)
        {
            if (Location.Y != 19 && speelveld.Array[Location.X, Location.Y + 1] is Leeg)
            {
                speelveld.Array[Location.X, Location.Y + 1] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.Y++;
            }
        }
    }
}
