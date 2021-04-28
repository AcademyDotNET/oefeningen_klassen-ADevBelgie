using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game\n");

            SpeelVeld speelVeld = new SpeelVeld();
            while (true)
            {
                
                Console.SetCursorPosition(0,2);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(speelVeld);
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.Z://vooruit
                        break;
                    case ConsoleKey.S://achteruit
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
                Console.SetCursorPosition(2, 0);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(speelVeld);
            }
        }
    }
}
