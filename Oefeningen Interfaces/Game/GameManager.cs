using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        public GameManager()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
        public Settings Settings { get; set; } = new Settings();
        public HiScores HiScores { get; set; } = new HiScores();
        public GameEngine GameEngine { get; set; } = new GameEngine();
        public int MainMenu()
        {
            //returns int value selected by the user
            string[] menuOptions = 
            {
                "Play Game",
                "Change Game settings/ keybinds (recommended!)",
                "Hiscore's",
                "Quit Game"
            };
            Menu mainMenu = new Menu(menuOptions);

            return mainMenu.Start();
        }
        public bool EndOfGame(Settings gameSettings)
        {
            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");

            while (true)
            {
                Program.ClearKeyBuffer();
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
                Program.ClearCurrentConsoleLine();
            }

        }
    }
}
