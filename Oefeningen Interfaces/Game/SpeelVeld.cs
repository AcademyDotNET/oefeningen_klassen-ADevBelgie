using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SpeelVeld
    {
        public SpeelVeld()
        {
            FillArray();
            InitSpeelVeld(Array);
        }
        public SpeelVeld(int chanceOfMonsters)
        {
            FillArray();
            InitSpeelVeld(Array, chanceOfMonsters);
        }
        private int arrayRows;
        private int arrayColumns;
        public MapElement[,] Array { get; set; }
        public Point PlayerLocation { get; set; }
        public List<Monster> AllMonsters { get; set; }
        public void Destroy(int row, int Col)
        {
            Array[row, Col] = new Leeg(row, Col);
        }
        private void FillArray()
        {
            arrayRows = 20;
            arrayColumns = 20;
            Array = new MapElement[arrayRows, arrayColumns];
            AllMonsters = new List<Monster>();
        }
        private void InitSpeelVeld(MapElement[,] speelVeld, int chanceOfMonsters = 5)
        {
            //generate monsters, rocks & empty spaces
            Random rand = new Random();
            for (int row = 0; row < speelVeld.GetLength(0); row++)
            {
                for (int col = 0; col < speelVeld.GetLength(1); col++)
                {
                    int genElement = rand.Next(1,4);
                    switch (genElement)
                    {
                        case 1:
                            genElement = rand.Next(0, chanceOfMonsters);
                            if (genElement == 0)
                                { 
                                    speelVeld[row, col] = new Monster(row, col);
                                    AllMonsters.Add((Monster)speelVeld[row, col]);
                                }
                            else
                                { speelVeld[row, col] = new Leeg(row, col); }
                            break;
                        case 2:
                            speelVeld[row, col] = new Leeg(row, col);
                            break;
                        case 3:
                            speelVeld[row, col] = new Rock(row, col);
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate player
            PlayerLocation = new Point() { X = 0, Y = 10 };
            speelVeld[0, 10] = new Player() { Location = PlayerLocation};
        }

        public void MoveMonsters()
        {
            Random rand = new Random();
            foreach (var monster in AllMonsters)
            {
                int roll = rand.Next(0,4); //4 directions
                switch (roll)
                {
                    case 0://Boven
                        monster.MoveUp(this);
                        break;
                    case 1://Onder
                        monster.MoveDown(this);
                        break;
                    case 2://links
                        monster.MoveLeft(this);
                        break;
                    case 3://rechts
                        monster.MoveRight(this);
                        break;
                    default:
                        break;
                }
            }
        }

        public override string ToString()
        {
            string playFieldString = "";
            for (int i = 0; i < arrayRows; i++)
            {
                for (int y = 0; y < arrayColumns; y++)
                {
                    if (Array[i, y].DitElementChar != SoortElementChar.L)
                    {
                        playFieldString += Array[i, y].DitElementChar + " ";
                    }
                    else
                    {
                        playFieldString += "  ";
                    }
                }
                playFieldString += "\n";
            }
            playFieldString += "+ + + + + + + +         + + + + + + + +\n";
            return playFieldString;
        }
    }
}
