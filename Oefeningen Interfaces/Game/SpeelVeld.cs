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
            InitGame();
            InitSpeelVeld();
        }
        public SpeelVeld(int chanceOfMonsters)
        {
            InitGame();
            InitSpeelVeld(chanceOfMonsters);
        }

        //speelveld array van [20, 20]
        private int arrayRows;
        private int arrayColumns;
        public MapElement[,] Array { get; set; }

        //Player location, start location is [0, 10]
        public Point PlayerLocation { get; set; } = new Point() { X = 0, Y = 10 };
        public List<Monster> AllMonsters { get; set; }

        private void InitGame()
        {
            arrayRows = 20;
            arrayColumns = 20;
            Array = new MapElement[arrayRows, arrayColumns];
            AllMonsters = new List<Monster>();
        }
        private void InitSpeelVeld(int chanceOfMonsters = 5)
        {
            //generate monsters, rocks & empty spaces
            Random rand = new Random();
            for (int row = 0; row < Array.GetLength(0); row++)
            {
                for (int col = 0; col < Array.GetLength(1); col++)
                {
                    int genElement = rand.Next(1,4);
                    switch (genElement)
                    {
                        case 1:
                            genElement = rand.Next(0, chanceOfMonsters);
                            if (genElement == 0)
                                {
                                    Array[row, col] = new Monster(row, col);
                                    AllMonsters.Add((Monster)Array[row, col]);
                                }
                            else
                                { Array[row, col] = new Leeg(row, col); }
                            break;
                        case 2:
                            Array[row, col] = new Leeg(row, col);
                            break;
                        case 3:
                            Array[row, col] = new Rock(row, col);
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate Rockdestroyer
            Remove(10, 10); //remove potential monster from the list
            Array[10, 10] = new RockDestroyer(10, 10);
            AllMonsters.Add((Monster)Array[10, 10]);

            //generate player(should be last)
            Remove(0, 10); //remove potential monster from the list
            Array[0, 10] = new Player() { Location = PlayerLocation};
        }
        private void Remove(int row, int col)
        {
            //replaces mapelement with Leeg element
            if (col > 0 && col < Array.GetLength(1) && row > 0 && row < Array.GetLength(0))
            {
                if (Array[row, col] is Monster || Array[row, col] is RockDestroyer)
                {
                    AllMonsters.RemoveAll(m => m.Location.X == row && m.Location.Y == col); //remove monster in monster list 
                }
                Array[row, col] = new Leeg(row, col);
            }
        }
        public override string ToString()
        {
            string playFieldString = "";
            for (int i = 0; i < arrayRows; i++)
            {
                for (int y = 0; y < arrayColumns; y++)
                {
                    playFieldString += Array[i, y].DitElementChar + " ";
                }
                playFieldString += "\n";
            }
            playFieldString += "+ + + + + + + +         + + + + + + + +\n";
            return playFieldString;
        }
    }
}
