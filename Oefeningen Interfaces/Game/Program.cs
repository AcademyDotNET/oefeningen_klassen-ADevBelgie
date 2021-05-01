using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main()
        {
            int keuze;
            Settings gameSettings = new Settings();
            
            do
            {
                keuze = Menu();
                switch (keuze)
                {
                    case 1:
                        PlayGame(gameSettings);
                        break;
                    case 2:
                        gameSettings.ChangeSettingsGame();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        break;
                }

            } while (keuze != 4);
        }

        

        private static int Menu()
        {
            Console.Clear();
            MenuOutput();

            while (true)
            {
                ClearKeyBuffer();
                ClearCurrentConsoleLine();
                ConsoleKey input = Console.ReadKey().Key;

                if (input == ConsoleKey.NumPad1 || input == ConsoleKey.D1)
                {
                    return 1;
                }
                else if (input == ConsoleKey.NumPad2 || input == ConsoleKey.D2)
                {
                    return 2;
                }
                else if (input == ConsoleKey.NumPad3 || input == ConsoleKey.D3)
                {
                    return 3;
                }
                else if (input == ConsoleKey.NumPad4 || input == ConsoleKey.D4)
                {
                    return 4;
                }
            }
        }

        private static void MenuOutput()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Change Game settings/ keybinds (recommended!)");
            Console.WriteLine("3. Hiscores (coming soon)");
            Console.WriteLine("4. Quit Game\n");
            Console.WriteLine("Press 1, 2, 3 or 4 to continue ");
        }

        private static void PlayGame(Settings gameSettings)
        {
            Console.Clear();
            GameInfo gameInfo = new GameInfo();
            gameInfo.DisplayInfo(gameSettings);
            
            SpeelVeld speelVeld = new SpeelVeld(gameSettings.Difficulty); // chance of monsters, 0 being the most amount of monsters
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];

            // game
            while (speelVeld.CurrentGameState == GameState.GameInProgress && speelVeld.GameScore.GameTurns < 500)
            {
                WriteSpeelveld(speelVeld);

                //players turn
                ConsoleKey input = Console.ReadKey().Key;
                if (input == gameSettings.MoveUpKey)
                {
                    player1.MoveUp(speelVeld);
                }
                else if (input == gameSettings.MoveDownKey)
                {
                    player1.MoveDown(speelVeld);
                }
                else if (input == gameSettings.MoveRightKey)
                {
                    player1.MoveRight(speelVeld);
                }
                else if (input == gameSettings.MoveLeftKey)
                {
                    player1.MoveLeft(speelVeld);
                }
                else if (input == gameSettings.ShootRightKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootRight(speelVeld);
                }
                else if (input == gameSettings.ShootLeftKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootLeft(speelVeld);
                }
                else if (input == ConsoleKey.Escape)
                {
                    speelVeld.CurrentGameState = GameState.ExitGameInProgress;
                }

                //monsters turn
                speelVeld.MoveMonsters();
                speelVeld.ShootMonsters();

                speelVeld.GameScore.GameTurns++;
                ClearSpeelveld(speelVeld);
            }
            if (speelVeld.GameScore.GameTurns >= 500)
            {
                speelVeld.CurrentGameState = GameState.LostByTurnLimit;
            }

            Console.Clear();

            // game over
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
                    break;
            }

            EndOfGame(gameSettings);
        }
        private static void EndOfGame(Settings gameSettings)
        {
            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");

            ClearKeyBuffer();
            ClearCurrentConsoleLine();
            ConsoleKey returnKey = Console.ReadKey().Key;

            while (returnKey != ConsoleKey.Enter && returnKey != ConsoleKey.Escape)
            {
                ClearCurrentConsoleLine();
                returnKey = Console.ReadKey().Key;
            }
            if (returnKey == ConsoleKey.Enter)
            {
                PlayGame(gameSettings);
            }

            Console.Clear();
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
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static void ClearKeyBuffer()
        {
            System.Threading.Thread.Sleep(180);
            while (Console.KeyAvailable)// skips previous input chars
                Console.ReadKey(false);
        }
    }
}
