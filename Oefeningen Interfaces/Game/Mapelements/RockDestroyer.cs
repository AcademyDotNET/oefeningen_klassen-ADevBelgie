using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RockDestroyer : Monster, IDestroyer
    {
        SpeelVeld speelveld;
        public RockDestroyer(int x, int y, SpeelVeld speelveld) : base(x, y, speelveld)
        {
            this.speelveld = speelveld;
            DitElementChar = SoortElementChar.X;
        }

        public void ShootLeft(GameManager gameManager)
        {
            //naar links schieten 
            Destroy(Location.X, Location.Y - 1, gameManager); //X is rows, Y is Cols
        }

        public void ShootRight(GameManager gameManager)
        {
            //naar rechts schieten 
            Destroy(Location.X, Location.Y + 1, gameManager);
        }

        public void Destroy(int row, int col, GameManager gameManager)
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
