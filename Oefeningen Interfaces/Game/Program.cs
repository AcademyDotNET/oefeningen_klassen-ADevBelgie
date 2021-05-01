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
                    default:
                        break;
                }

            } while (keuze != 3);
        }

        

        private static int Menu()
        {
            MenuOutput();
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
                {
                    return 1;
                }
                else if (input.Key == ConsoleKey.NumPad2 || input.Key == ConsoleKey.D2)
                {
                    return 2;
                }
                else if (input.Key == ConsoleKey.NumPad3 || input.Key == ConsoleKey.D3)
                {
                    return 3;
                }
                else
                {
                    Console.Clear();
                    MenuOutput();
                }
            }
        }

        private static void MenuOutput()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Change Game settings/ keybinds (recommended!)");
            Console.WriteLine("3. Quit Game\n");
            Console.Write("Press 1, 2 or 3 to continue ");
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
                else if (input.Key == ConsoleKey.Escape)
                {
                    speelVeld.CurrentGameState = GameState.ExitGameInProgress;
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
                    break;
            }

            EndOfGame(gameSettings);
        }
        private static void EndOfGame(Settings gameSettings)
        {
            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");
            System.Threading.Thread.Sleep(180);
            while (Console.KeyAvailable)// skips previous input chars
                Console.ReadKey(false);
            var SavePosition = Console.GetCursorPosition();
            ClearCurrentConsoleLine();
            ConsoleKey returnKey = Console.ReadKey().Key;
            while (returnKey != ConsoleKey.Enter && returnKey != ConsoleKey.Escape)
            {

                Console.SetCursorPosition(0, SavePosition.Top);
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
    }
}
