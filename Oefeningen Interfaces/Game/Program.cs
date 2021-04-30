using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game z=up, s=down, q=left, d=right, a=shootleft, e=shootright, Any other key=skip turn\n");

            SpeelVeld speelVeld = new SpeelVeld(6); // chance of monsters, 0 being the most amount of monsters
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];

            // game
            while (speelVeld.CurrentGameState == GameState.GameInProgress && speelVeld.GameScore.GameTurns < 500)
            {
                WriteSpeelveld(speelVeld);

                //players turn
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
                        speelVeld.GameScore.ShotsFired++;
                        player1.ShootLeft(speelVeld);
                        break;
                    case ConsoleKey.E: //schieten
                        speelVeld.GameScore.ShotsFired++;
                        player1.ShootRight(speelVeld);
                        break;
                    default:
                        break;
                }
                //monsters turn
                speelVeld.MoveMonsters();
                speelVeld.ShootMonsters();

                speelVeld.GameScore.GameTurns++;
                ClearSpeelveld(speelVeld);            
            }
            
            Console.Clear();
            // game over
            if (speelVeld.GameScore.GameTurns >= 500)
            {
                speelVeld.CurrentGameState = GameState.LostByTurnLimit;
            }
            switch (speelVeld.CurrentGameState)
            {
                case GameState.Won:
                    speelVeld.WinScreen();
                    break;
                case GameState.LostByWalkingIntoMonster:
                case GameState.LostByDestroyer:
                case GameState.LostByTurnLimit:
                    speelVeld.LoseScreen();
                    break;
                default:
                    Console.WriteLine("You went over this games limits...");
                    break;
            }
            
        }

        private static void WriteSpeelveld(SpeelVeld speelVeld)
        {
            Console.SetCursorPosition(0, 2);
            //STRING SPLIT voor kleuren
            string stringSpeelVeld = speelVeld.ToString();
            string[] subStringSpeelVeld = stringSpeelVeld.Split(' ');
            foreach (var mapElement in subStringSpeelVeld)
            {
                switch (mapElement)
                {
                    case "P":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "M":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "R":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "X":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.Write(mapElement+" ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
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
