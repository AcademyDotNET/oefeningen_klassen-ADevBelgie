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
        public void MainMenu()
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

            int keuze;
            do
            {
                keuze = mainMenu.Start();
                switch (keuze)
                {
                    case 1:
                        while (GameEngine.Start(this)) { }
                        break;
                    case 2:
                        Settings.ChangeSettingsGame();
                        break;
                    case 3:
                        HiScores.ShowHiScores();
                        break;
                    default:
                        break;
                }

            } while (keuze != 4);
        }
        public bool EndOfGame(Settings gameSettings)
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();
            Console.WriteLine("\n\nPress enter to play again... or ESC to go back to menu");

            while (true)
            {
                input.GetKey();

                if (input.UserInputKey == ConsoleKey.Enter)
                {
                    return true;
                }
                else if (input.UserInputKey == ConsoleKey.Escape)
                {
                    return false;
                }
            }

        }
    }
}
