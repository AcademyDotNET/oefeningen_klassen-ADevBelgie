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
            DitElementChar = SoortElementChar.P;
        }
        public void ShootRight(SpeelVeld speelveld, GameManager gameManager)
        {
            //naar rechts schieten 
            Destroy(Location.X, Location.Y + 1, speelveld, gameManager); //X is rows, Y is Cols
        }
        public void ShootLeft(SpeelVeld speelveld, GameManager gameManager)
        {
            //naar links schieten 
            Destroy(Location.X, Location.Y - 1, speelveld, gameManager); //X is rows, Y is Cols
        }
        public void Destroy(int row, int col, SpeelVeld speelveld, GameManager gameManager)
        {
            if (col >= 0 && col < speelveld.Array.GetLength(1))
            {
                if (speelveld.Array[row, col] is Monster ) //het is niet mogelijk een rockdestroyer te doden
                {
                    gameManager.GameScore.MonstersKilled++;
                    speelveld.AllMonsters.Remove(speelveld.Array[row, col] as Monster); //also gets removed from monster list
                }
                else if (speelveld.Array[row, col] is Rock)
                {
                    gameManager.GameScore.RockDestroyed++;
                }
                speelveld.Array[row, col] = new Leeg(row, col);
            }
        }
        public void Move(int direction, SpeelVeld speelveld, GameManager gameManager)
        {
            switch (direction)
            {
                case 0: //up
                    speelveld.MoveElement(this, Location.X -1 , Location.Y, gameManager);
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
