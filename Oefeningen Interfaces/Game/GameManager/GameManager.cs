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
            IUserOutput output = new UserOutput();

            switch (CurrentGameState)
            {
                case GameState.LostByDestroyer:
                    output.WriteLine("You lost the game by the destroyer.");
                    output.WriteLine("\nHint:\nThe destroyer destroys anything to his left and right wherever he goes.");
                    output.WriteLine("Be careful not to get too close.");
                    break;
                case GameState.LostByWalkingIntoMonster:
                    output.WriteLine("You lost the game by walking into a monster.");
                    output.WriteLine("\nHint:\nMonsters don't attack on their own,");
                    output.WriteLine("as long as you don't walk into them, they are harmless.");
                    break;
                case GameState.LostByTurnLimit:
                    output.WriteLine("Congratulations! You lost the game by turn limit.");
                    output.WriteLine("This is an achievement on it's own.");
                    break;
                default:
                    output.WriteLine("You lost the game by unknown");
                    break;
            }
            output.WriteLine($"\n\n\nTurns elapsed: {GameScore.GameTurns}");
        }

        public void WinScreen()
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            output.Clear();
            output.WriteLine("You won the game");
            output.WriteLine($"\nTurns elapsed: {GameScore.GameTurns}");
            output.WriteLine($"Shots fired: {GameScore.ShotsFired}");
            output.WriteLine($"Monsters killed: {GameScore.MonstersKilled}");
            output.WriteLine($"Rocks destroyed: {GameScore.RockDestroyed}");
            output.WriteLine($"Accuracy: {(GameScore.ShotsFired != 0 ? ((GameScore.MonstersKilled + GameScore.RockDestroyed) / GameScore.ShotsFired) * 100 : 100)}%");
            output.WriteLine($"\nScore: {GameScore}");
            output.WriteLine($"\nTurns elapsed has the biggest influence on the score");

            output.WriteLine($"\nWilt u deze score toevoegen aan de Hiscore's?(Y/N)");
            input.UserInputKey = input.Enter;
            while (input.UserInputKey != input.N)
            {
                input.GetKey();

                if (input.UserInputKey == input.Y)
                {
                    output.WriteLine($"\nOnder welke naam?");
                    HiScores.AddEntry(GameScore.ToString(), input.ReadLine());
                    input.UserInputKey = input.N;
                }
            }

            output.WriteLine($"\n{HiScores}");

            System.Threading.Thread.Sleep(200);
        }
        public bool EndOfGameEngine()
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            output.WriteLine("Press enter to play again... or ESC to go back to menu");
            CurrentGameState = GameState.InMenu;

            while (true)
            {
                input.GetKey();

                if (input.UserInputKey == input.Enter)
                {
                    return true;
                }
                else if (input.UserInputKey == input.Escape)
                {
                    return false;
                }
            }
        }
    }
}
