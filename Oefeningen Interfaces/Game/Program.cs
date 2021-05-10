using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main()
        {
            GameManager gameManager = new GameManager();

            int keuze;
            do
            {
                keuze = gameManager.MainMenu();
                switch (keuze)
                {
                    case 1:
                        while (gameManager.GameEngine.Start(gameManager)) {}
                        break;
                    case 2:
                        gameManager.Settings.ChangeSettingsGame();
                        break;
                    case 3:
                        gameManager.HiScores.ShowHiScores();
                        break;
                    default:
                        break;
                }

            } while (keuze != 4);
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
