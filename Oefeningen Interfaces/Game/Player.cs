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
            Destroy(Location.X, Location.Y + 1, speelveld); //X is rows, Y is Cols
        }
        public void ShootLeft(SpeelVeld speelveld)
        {
            //naar links schieten 
            Destroy(Location.X, Location.Y - 1, speelveld); //X is rows, Y is Cols
        }
        public void Destroy(int row, int col, SpeelVeld speelveld)
        {
            if (row < speelveld.Array.GetLength(0) && col < speelveld.Array.GetLength(1))
            {
                if (speelveld.Array[row, col].DitElement == SoortElement.Monster) //het is niet mogelijk een rockdestroyer te doden
                {
                    speelveld.GameScore.MonstersKilled++; 
                    speelveld.AllMonsters.RemoveAll(m => m.Location.X == row && m.Location.Y == col); //remove monster in monster list 
                }
                else if (speelveld.Array[row, col].DitElement == SoortElement.Rock)
                {
                    speelveld.GameScore.RockDestroyed++;
                }
                speelveld.Array[row, col] = new Leeg(row, col);
            }
        }
        public void MoveUp(SpeelVeld speelveld)
        {
            if (Location.X != 0)//check if map border
            {
                if ((new SoortElement[] { SoortElement.Monster, SoortElement.RockDestroyer }.Contains(speelveld.Array[Location.X - 1, Location.Y].DitElement)))
                {
                    speelveld.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if(speelveld.Array[Location.X - 1, Location.Y].DitElement == SoortElement.Leeg)
                {
                    speelveld.Array[Location.X - 1, Location.Y] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.X--;
                }
            }
        }
        public void MoveDown(SpeelVeld speelveld)
        {
            if (Location.X != 19)//check if map border
            {
                if ((new SoortElement[] { SoortElement.Monster, SoortElement.RockDestroyer }.Contains(speelveld.Array[Location.X + 1, Location.Y].DitElement)))
                {
                    speelveld.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X + 1, Location.Y].DitElement == SoortElement.Leeg)
                {
                    speelveld.Array[Location.X + 1, Location.Y] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.X++;
                }
            }
            else if (Location.X == 19 && Location.Y < 12 && Location.Y > 7)
            {
                speelveld.CurrentGameState = GameState.Won;
            }
        }
        public void MoveLeft(SpeelVeld speelveld)
        {
            if (Location.Y != 0) //check if map border
            {
                if ((new SoortElement[] { SoortElement.Monster, SoortElement.RockDestroyer }.Contains(speelveld.Array[Location.X, Location.Y - 1].DitElement)))
                {
                    speelveld.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X, Location.Y - 1].DitElement == SoortElement.Leeg)
                {
                    speelveld.Array[Location.X, Location.Y - 1] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.Y--;
                }
            }
        }
        public void MoveRight(SpeelVeld speelveld)
        {
            if (Location.Y != 19) //check if map border
            {
                if ((new SoortElement[] { SoortElement.Monster, SoortElement.RockDestroyer }.Contains(speelveld.Array[Location.X, Location.Y + 1].DitElement)))
                {
                    speelveld.CurrentGameState = GameState.LostByWalkingIntoMonster;
                }
                else if (speelveld.Array[Location.X, Location.Y + 1].DitElement == SoortElement.Leeg)
                {
                    speelveld.Array[Location.X, Location.Y + 1] = this;
                    speelveld.Array[Location.X, Location.Y] = new Leeg(Location.X, Location.Y);
                    Location.Y++;
                }
            }
        }
    }
}
