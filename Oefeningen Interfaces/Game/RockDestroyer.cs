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
            Destroy(Location.X, Location.Y - 1, speelveld); //X is rows, Y is Cols
        }

        public void ShootRight(SpeelVeld speelveld)
        {
            //naar rechts schieten 
            Destroy(Location.X, Location.Y + 1, speelveld);
        }

        public void Destroy(int row, int col, SpeelVeld speelveld)
        {
            if (col >= 0 && col < speelveld.Array.GetLength(1))
            {
                if (speelveld.Array[row, col].DitElement == SoortElement.Player)
                {
                    speelveld.CurrentGameState = GameState.LostByDestroyer;
                }
                else if (speelveld.Array[row, col].DitElement == SoortElement.Rock)
                {
                    speelveld.GameScore.RockDestroyed++;
                    speelveld.Array[row, col] = new Leeg(row, col); //remove Rock in SpeeldVeld.Array 
                }
            }
        }
    }
}
