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
        private int arrayRows;
        private int arrayColumns;
        public MapElement[,] Array { get; set; }

        private void InitSpeelVeld(MapElement[,] speelVeld)
        {
            //generate monsters, rocks & empty spaces
            Random rand = new Random();
            for (int i = 0; i < speelVeld.GetLength(0); i++)
            {
                for (int y = 0; y < speelVeld.GetLength(1); y++)
                {
                    int genElement = rand.Next(1,4);
                    switch (genElement)
                    {
                        case 1:
                            speelVeld[i, y] = new Monster();
                            break;
                        case 2:
                            speelVeld[i, y] = new Leeg();
                            break;
                        case 3:
                            speelVeld[i, y] = new Rock();
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate player
            speelVeld[0, 10] = new Player();
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
            return playFieldString;
        }
    }
}
