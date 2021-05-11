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
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();
            output.Clear();
            
            output.WriteLine("Hiscore's:\n");
            output.ForegroundColor = ConsoleColor.Yellow;
            output.WriteLine(this.ToString());
            output.ForegroundColor = ConsoleColor.Gray;

            output.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");
            while (true)
            {
                input.GetKey();

                if (input.UserInputKey == ConsoleKey.Enter)
                {
                    return;
                }
                else if (input.UserInputKey == ConsoleKey.Escape)
                {
                    output.Write("A");//added character here because code eats it somewhere
                    return;
                }
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
