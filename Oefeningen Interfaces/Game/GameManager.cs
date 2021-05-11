using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum GameState { GameInProgress, InMenu, Won, LostByDestroyer, LostByWalkingIntoMonster, LostByTurnLimit, LostByError, ExitGameInProgress }
    class GameManager
    {
        public GameManager()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CurrentGameState = GameState.InMenu;
        }
        public Settings Settings { get; set; } = new Settings();
        public HiScores HiScores { get; set; } = new HiScores();
        public GameEngine GameEngine { get; set; } = new GameEngine();
        public Score GameScore { get; set; } = new Score();
        public GameState CurrentGameState { get; set; }
        
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
        public void LoseScreen()
        {
            switch (CurrentGameState)
            {
                case GameState.LostByDestroyer:
                    Console.WriteLine("You lost the game by the destroyer.");
                    Console.WriteLine("\nHint:\nThe destroyer destroys anything to his left and right wherever he goes.");
                    Console.WriteLine("Be careful not to get too close.");
                    break;
                case GameState.LostByWalkingIntoMonster:
                    Console.WriteLine("You lost the game by walking into a monster.");
                    Console.WriteLine("\nHint:\nMonsters don't attack on their own,");
                    Console.WriteLine("as long as you don't walk into them, they are harmless.");
                    break;
                case GameState.LostByTurnLimit:
                    Console.WriteLine("Congratulations! You lost the game by turn limit.");
                    Console.WriteLine("This is an achievement on it's own.");
                    break;
                default:
                    Console.WriteLine("You lost the game by unknown");
                    break;
            }
            Console.WriteLine($"\n\n\nTurns elapsed: {GameScore.GameTurns}");
        }

        public void WinScreen()
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            Console.WriteLine("You won the game");
            Console.WriteLine($"\nTurns elapsed: {GameScore.GameTurns}");
            Console.WriteLine($"Shots fired: {GameScore.ShotsFired}");
            Console.WriteLine($"Monsters killed: {GameScore.MonstersKilled}");
            Console.WriteLine($"Rocks destroyed: {GameScore.RockDestroyed}");
            Console.WriteLine($"Accuracy: {(GameScore.ShotsFired != 0 ? ((GameScore.MonstersKilled + GameScore.RockDestroyed) / GameScore.ShotsFired) * 100 : 100)}%");
            Console.WriteLine($"\nScore: {GameScore}");
            Console.WriteLine($"\nTurns elapsed has the biggest influence on the score");

            //add to highscore (BP - 7143)
            Console.WriteLine($"\nWilt u deze score toevoegen aan de Hiscore's?(Y/N)");
            input.UserInputKey = ConsoleKey.Enter;
            while (input.UserInputKey != ConsoleKey.N)
            {
                input.GetKey();

                if (input.UserInputKey == ConsoleKey.Y)
                {
                    Console.WriteLine($"\nOnder welke naam?");
                    HiScores.AddEntry(GameScore.ToString(), Console.ReadLine());
                    input.UserInputKey = ConsoleKey.N;
                }
            }

            Console.WriteLine($"\n{HiScores}");

            System.Threading.Thread.Sleep(200);
        }
        public bool EndOfGameEngine()
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            output.WriteLine("Press enter to play again... or ESC to go back to menu");

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
