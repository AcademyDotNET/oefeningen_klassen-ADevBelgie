using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game\n");

            SpeelVeld speelVeld = new SpeelVeld(0); // chance of monsters, 0 being the most amount of monsters
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];

            while (true)
            {
                WriteSpeelveld(speelVeld);
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.Z://Boven
                        player1.MoveUp(speelVeld);
                        break;
                    case ConsoleKey.S://Onder
                        player1.MoveDown(speelVeld);
                        break;
                    case ConsoleKey.Q://links
                        player1.MoveLeft(speelVeld);
                        break;
                    case ConsoleKey.D://rechts
                        player1.MoveRight(speelVeld);
                        break;
                    case ConsoleKey.A: //schieten
                        player1.ShootLeft(speelVeld);
                        break;
                    case ConsoleKey.E: //schieten
                        player1.ShootRight(speelVeld);
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
