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
            DitElementChar = SoortElementChar.X;
        }

        public void ShootLeft(SpeelVeld speelveld, GameManager gameManager)
        {
            //naar links schieten 
            Destroy(Location.X, Location.Y - 1, speelveld, gameManager); //X is rows, Y is Cols
        }

        public void ShootRight(SpeelVeld speelveld, GameManager gameManager)
        {
            //naar rechts schieten 
            Destroy(Location.X, Location.Y + 1, speelveld, gameManager);
        }

        public void Destroy(int row, int col, SpeelVeld speelveld, GameManager gameManager)
        {
            if (col >= 0 && col < speelveld.Array.GetLength(1))
            {
                if (speelveld.Array[row, col] is Player)
                {
                    gameManager.CurrentGameState = GameState.LostByDestroyer;
                }
                else if (speelveld.Array[row, col] is Rock)
                {
                    speelveld.Array[row, col] = new Leeg(row, col); //remove Rock in SpeeldVeld.Array 
                }
            }
        }
    }
}
