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
                        while (PlayGame(gameSettings)) {}
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
            //returns int value selected by the user
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
            }
        }
        private static void MenuOutput()
        {
            //Writes to console what options the user can choose from
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Change Game settings/ keybinds (recommended!)");
            Console.WriteLine("3. Quit Game\n");
            Console.WriteLine("Press 1, 2, 3 or 4 to continue ");
        }

        private static bool PlayGame(Settings gameSettings)
        {
            Console.Clear();

            //init game settings and map elements
            GameInfo gameInfo = new GameInfo();
            gameInfo.DisplayInfo(gameSettings);
            SpeelVeld speelVeld = new SpeelVeld(gameSettings.Difficulty);
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];

            // game
            while (speelVeld.CurrentGameState == GameState.GameInProgress)
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
                if (speelVeld.GameScore.GameTurns >= 150)
                {
                    speelVeld.CurrentGameState = GameState.LostByTurnLimit;
                }
                ClearSpeelveld(speelVeld);
            }
            
            // game over result screen
            Console.Clear();
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

            //if end of game return true, the PlayGame method will be called again
            return EndOfGame(gameSettings);
        }
        private static bool EndOfGame(Settings gameSettings)
        {
            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");

            while (true)
            {
                ClearKeyBuffer();
                ConsoleKey returnKey = Console.ReadKey().Key; //this line seems to eat character when ESC is pressed
                
                if (returnKey == ConsoleKey.Enter)
                {
                    return true;
                }
                else if (returnKey == ConsoleKey.Escape)
                {
                    Console.Write("A");//added character here because code eats it somewhere
                    return false;
                }
                ClearCurrentConsoleLine();
            }
            
        }

        private static void WriteSpeelveld(SpeelVeld speelVeld)
        {
            //writes speeldveld to console
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
            //clears speeldveld in console
            //this is way faster then using Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(speelVeld);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ClearCurrentConsoleLine()
        {
            //clears the line in the console, is used for in menu screens or end of game screen
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static void ClearKeyBuffer()
        {
            // skips previous input chars.
            // this method is here for if people hold down a key for too long causing the button press to go into a buffer.
            System.Threading.Thread.Sleep(180);
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
    }
}
