using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player:MapElement, IMovable, IDestroyer
    {
        public Player()
        {
            DitElement = SoortElement.Player;
            DitElementChar = SoortElementChar.P;
        }
        public void ShootRight(SpeelVeld speelveld)
        {
            //naar rechts schieten 
            speelveld.Destroy(Location.X, Location.Y + 1); //X is rows, Y is Cols
        }
        public void ShootLeft(SpeelVeld speelveld)
        {
            //naar rechts schieten 
            speelveld.Destroy(Location.X, Location.Y - 1); //X is rows, Y is Cols
        }
        public void MoveUp(SpeelVeld speelveld)
        {
            if (Location.X != 0 && speelveld.Array[Location.X - 1, Location.Y].DitElement == SoortElement.Leeg)
            {
                speelveld.Array[Location.X - 1, Location.Y] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.X--;
            }
        }
        public void MoveDown(SpeelVeld speelveld)
        {
            if (Location.X != 19 && speelveld.Array[Location.X + 1, Location.Y].DitElement == SoortElement.Leeg)
            {
                speelveld.Array[Location.X + 1, Location.Y] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.X++;
            }
            if (Location.X == 19 && Location.Y < 12 && Location.Y > 8)
            {
                Console.WriteLine("You won");
            }
        }
        public void MoveLeft(SpeelVeld speelveld)
        {
            if (Location.Y != 0 && speelveld.Array[Location.X, Location.Y - 1].DitElement == SoortElement.Leeg)
            {
                speelveld.Array[Location.X, Location.Y - 1] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.Y--;
            }
        }
        public void MoveRight(SpeelVeld speelveld)
        {
            if (Location.Y != 19 && speelveld.Array[Location.X, Location.Y + 1].DitElement == SoortElement.Leeg)
            {
                speelveld.Array[Location.X, Location.Y + 1] = this;
                speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                Location.Y++;
            }
        }
    }
}
