using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class HiScores
    {
        public HiScores()
        {
            AddEntry("7143", "Arthur");
            AddEntry("7143", "Özge");
        }
        public List<string[]> ListHiScores { get; set; } = new List<string[]>();
        public void AddEntry(string newEntry, string name)
        {
            ListHiScores.Add(new string[]{ newEntry,name});
            ListHiScores.Sort((e1, e2) => Convert.ToInt32(e2[0]).CompareTo(Convert.ToInt32(e1[0])));
        }
        public void ShowHiScores()
        {
            Console.Clear();
            Console.WriteLine("Hiscore's:");
            Console.WriteLine(this);


            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");
            while (true)
            {
                Program.ClearKeyBuffer();
                ConsoleKey returnKey = Console.ReadKey().Key; //this line seems to eat character when ESC is pressed

                if (returnKey == ConsoleKey.Enter)
                {
                    return;
                }
                else if (returnKey == ConsoleKey.Escape)
                {
                    Console.Write("A");//added character here because code eats it somewhere
                    return;
                }
                Program.ClearCurrentConsoleLine();
            }
        }
        public override string ToString()
        {
            string totalString = "";
            for (int i = 0; i < ListHiScores.Count; i++)
            {
                totalString += $"{i+1}. {ListHiScores[i][0]} {ListHiScores[i][1]}\n";
            }
            return totalString;
        }
    }
}
