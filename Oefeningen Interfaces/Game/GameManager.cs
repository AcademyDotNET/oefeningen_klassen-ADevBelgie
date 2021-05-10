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
        public Settings settings { get; set; } = new Settings();
        public HiScores hiScores { get; set; } = new HiScores();

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
        
    }
}
