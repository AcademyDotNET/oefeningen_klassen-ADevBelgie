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
        public void MoveUp(SpeelVeld speelveld, GameManager gameManager)
        {
            if (Location.X != 0)//check if map border
            {
                if (speelveld.Array[Location.X - 1, Location.Y] is Monster)
                {
                    gameManager.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X - 1, Location.Y] is RockDestroyer)
                {
                    gameManager.CurrentGameState = GameState.LostByDestroyer;
                }
                else if(speelveld.Array[Location.X - 1, Location.Y] is Leeg)
                {
                    speelveld.Array[Location.X - 1, Location.Y] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.X--;
                }
            }
        }
        public void MoveDown(SpeelVeld speelveld, GameManager gameManager)
        {
            if (Location.X != 19)//check if map border
            {
                if (speelveld.Array[Location.X + 1, Location.Y] is Monster)
                {
                    gameManager.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X + 1, Location.Y] is RockDestroyer)
                {
                    gameManager.CurrentGameState = GameState.LostByDestroyer;
                }
                else if (speelveld.Array[Location.X + 1, Location.Y] is Leeg)
                {
                    speelveld.Array[Location.X + 1, Location.Y] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.X++;
                }
            }
            else if (Location.X == 19 && Location.Y < 12 && Location.Y > 7)
            {
                gameManager.CurrentGameState = GameState.Won;
            }
        }
        public void MoveLeft(SpeelVeld speelveld, GameManager gameManager)
        {
            if (Location.Y != 0) //check if map border
            {
                if (speelveld.Array[Location.X, Location.Y - 1] is Monster)
                {
                    gameManager.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X, Location.Y - 1] is RockDestroyer)
                {
                    gameManager.CurrentGameState = GameState.LostByDestroyer;
                }
                else if (speelveld.Array[Location.X, Location.Y - 1] is Leeg)
                {
                    speelveld.Array[Location.X, Location.Y - 1] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.Y--;
                }
            }
        }
        public void MoveRight(SpeelVeld speelveld, GameManager gameManager)
        {
            if (Location.Y != 19) //check if map border
            {
                if (speelveld.Array[Location.X, Location.Y + 1] is Monster)
                {
                    gameManager.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X, Location.Y + 1] is RockDestroyer)
                {
                    gameManager.CurrentGameState = GameState.LostByDestroyer;
                }
                else if (speelveld.Array[Location.X, Location.Y + 1] is Leeg)
                {
                    speelveld.Array[Location.X, Location.Y + 1] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.Y++;
                }
            }
        }
    }
}
