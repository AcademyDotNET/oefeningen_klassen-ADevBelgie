using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game\n");

            SpeelVeld speelVeld = new SpeelVeld(5); // chance of monsters, 0 being the most amount of monsters
            while (true)
            {
                WriteSpeelveld(speelVeld);
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.Z://Boven
                        break;
                    case ConsoleKey.S://Onder
                        break;
                    case ConsoleKey.Q://links
                        break;
                    case ConsoleKey.D://rechts
                        break;
                    case ConsoleKey.A: //schieten
                        break;
                    default:
                        break;
                }
                ClearSpeelveld(speelVeld);            
            }
        }

        private static void WriteSpeelveld(SpeelVeld speelVeld)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(speelVeld);
        }

        private static void ClearSpeelveld(SpeelVeld speelVeld)
        {
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(speelVeld);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
