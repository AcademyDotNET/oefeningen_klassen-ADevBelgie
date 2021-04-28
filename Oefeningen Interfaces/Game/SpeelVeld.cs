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
            arrayRows = 20;
            arrayColumns = 20;
            Array = new MapElement[arrayRows, arrayColumns];
            InitSpeelVeld(Array);
        }
        public SpeelVeld(int chanceOfMonsters)
        {
            arrayRows = 20;
            arrayColumns = 20;
            Array = new MapElement[arrayRows, arrayColumns];
            InitSpeelVeld(Array, chanceOfMonsters);
        }
        private int arrayRows;
        private int arrayColumns;
        public MapElement[,] Array { get; set; }

        private void InitSpeelVeld(MapElement[,] speelVeld, int chanceOfMonsters = 5)
        {
            //generate monsters, rocks & empty spaces
            Random rand = new Random();
            for (int x = 0; x < speelVeld.GetLength(0); x++)
            {
                for (int y = 0; y < speelVeld.GetLength(1); y++)
                {
                    int genElement = rand.Next(1,4);
                    switch (genElement)
                    {
                        case 1:
                            genElement = rand.Next(0, chanceOfMonsters);
                            if (genElement == 0)
                                { speelVeld[x, y] = new Monster(x, y);  }
                            else
                                { speelVeld[x, y] = new Leeg(x, y); }
                            break;
                        case 2:
                            speelVeld[x, y] = new Leeg(x, y);
                            break;
                        case 3:
                            speelVeld[x, y] = new Rock(x, y);
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate player
            speelVeld[0, 10] = new Player(0, 10);
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
            return playFieldString;
        }
    }
}
