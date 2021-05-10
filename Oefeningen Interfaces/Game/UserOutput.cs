using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class UserOutput: IUserOutput
    {
        public void WriteLine(string toWrite = "")
        {
            Console.WriteLine(toWrite);
        }
        public void Write(string toWrite = "")
        {
            Console.Write(toWrite);
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void WriteSpeelveld(SpeelVeld speelVeld, Settings gameSettings)
        {
            //writes speeldveld to console
            Console.SetCursorPosition(0, 2);
            //STRING SPLIT voor kleuren
            string stringSpeelVeld = speelVeld.ToString();
            string[] linesSpeelVeld = stringSpeelVeld.Split('\n');
            foreach (var line in linesSpeelVeld)
            {
                string[] subStringLine = line.Split(' ');
                foreach (var mapElement in subStringLine)
                {
                    switch (mapElement)
                    {
                        case "P":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{gameSettings.PlayerChar} ");
                            break;
                        case "M":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{gameSettings.MonsterChar} ");
                            break;
                        case "R":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write($"{gameSettings.RockChar} ");
                            break;
                        case "X":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write($"{gameSettings.RockDestroyerChar} ");
                            break;
                        case "L":
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"  ");
                            break;
                        case "+":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write($"+ ");
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(mapElement + " ");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void ClearSpeelveld(SpeelVeld speelVeld)
        {
            //clears speeldveld in console
            //this is way faster then using Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(speelVeld);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
