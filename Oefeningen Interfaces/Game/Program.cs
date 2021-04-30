using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze;
            Settings gameSettings = new Settings();

            do
            {
                keuze = Menu();
                switch (keuze)
                {
                    case "1":
                        PlayGame(gameSettings);
                        break;
                    case "2":
                        ChangeSettingsGame(gameSettings);
                        break;
                    default:
                        break;
                }

            } while (keuze != "3");
        }

        private static void ChangeSettingsGame(Settings gameSettings)
        {
            throw new NotImplementedException();
        }

        private static string Menu()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Change settings Game");
            Console.WriteLine("3. Quit Game");
            int userKeuze;
            int[] keuzes = { 1, 2, 3 };
            while ( !int.TryParse(Console.ReadLine(), out userKeuze) && !keuzes.Contains(userKeuze) )
            {
                Console.WriteLine("Geef een valide Keuze");
            }
            return Convert.ToString(userKeuze);
        }

        private static void PlayGame(Settings gameSettings)
        {
            Console.Clear();
            Console.WriteLine("Game z=up, s=down, q=left, d=right, a=shootleft, e=shootright, Any other key=skip turn\n");
            SpeelVeld speelVeld = new SpeelVeld(6); // chance of monsters, 0 being the most amount of monsters
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];

            // game
            while (speelVeld.CurrentGameState == GameState.GameInProgress && speelVeld.GameScore.GameTurns < 500)
            {
                WriteSpeelveld(speelVeld);

                //players turn
                var input = Console.ReadKey();
                if (input.Key == gameSettings.MoveUpKey)
                {
                    player1.MoveUp(speelVeld);
                }
                else if (input.Key == gameSettings.MoveDownKey)
                {
                    player1.MoveDown(speelVeld);
                }
                else if (input.Key == gameSettings.MoveRightKey)
                {
                    player1.MoveRight(speelVeld);
                }
                else if (input.Key == gameSettings.MoveLeftKey)
                {
                    player1.MoveLeft(speelVeld);
                }
                else if (input.Key == gameSettings.ShootRightKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootRight(speelVeld);
                }
                else if (input.Key == gameSettings.ShootLeftKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootLeft(speelVeld);
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
