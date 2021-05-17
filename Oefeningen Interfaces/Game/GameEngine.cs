using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameEngine
    {
        public bool Start(GameManager gameManager)
        {
            // Init game
            InitGameScreen(gameManager);
            gameManager.GameScore = new Score();
            SpeelVeld speelVeld = new SpeelVeld(gameManager.Settings.Difficulty);
            Player player = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];
            gameManager.CurrentGameState = GameState.GameInProgress;

            // Game loop
            while (gameManager.CurrentGameState == GameState.GameInProgress)
            {
                WriteGameField(speelVeld, gameManager);
                
                // Get user key and perform action
                UserTurn(gameManager, speelVeld, player);

                // monsters move in random direction & RockDestroyer schiet
                MonsterTurn(gameManager, speelVeld);

                gameManager.GameScore.GameTurns++;
                if (gameManager.GameScore.GameTurns >= 150)
                {
                    gameManager.CurrentGameState = GameState.LostByTurnLimit;
                }
            }

            // Result screen
            ResultScreen(gameManager);
            
            // if end of game return true, the PlayGame method will be called again
            return gameManager.EndOfGameEngine();
        }
        public void InitGameScreen(GameManager gameManager)
        {
            IUserOutput output = new UserOutput();

            output.Clear();
            GameInfo gameInfo = new GameInfo();
            gameInfo.DisplayInfo(gameManager.Settings);
        }
        public void WriteGameField(SpeelVeld speelVeld, GameManager gameManager)
        {
            IUserOutput output = new UserOutput();

            output.ClearSpeelveld(speelVeld);
            output.WriteSpeelveld(speelVeld, gameManager.Settings);
        }
        public void UserTurn(GameManager gameManager, SpeelVeld speelVeld, Player player)
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            input.GetKey();
            if (input.UserInputKey == gameManager.Settings.MoveUpKey)
            {
                player.Move(0, gameManager);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveRightKey)
            {
                player.Move(1, gameManager);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveDownKey)
            {
                player.Move(2, gameManager);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveLeftKey)
            {
                player.Move(3, gameManager);
            }
            else if (input.UserInputKey == gameManager.Settings.ShootRightKey)
            {
                gameManager.GameScore.ShotsFired++;
                player.ShootRight(gameManager);
            }
            else if (input.UserInputKey == gameManager.Settings.ShootLeftKey)
            {
                gameManager.GameScore.ShotsFired++;
                player.ShootLeft(gameManager);
            }
            else if (input.UserInputKey == input.Escape)
            {
                gameManager.CurrentGameState = GameState.ExitGameInProgress;
            }
        }
        public void MonsterTurn(GameManager gameManager, SpeelVeld speelVeld)
        {
            MonstersMove(gameManager, speelVeld);
            MonstersSchoot(gameManager, speelVeld);
        }
        public void MonstersSchoot(GameManager gameManager, SpeelVeld speelVeld)
        {
            //makes the rockdetroyer shoot
            for (int i = 0; i < speelVeld.AllMonsters.Count; i++)
            {
                RockDestroyer RD = speelVeld.AllMonsters[i] as RockDestroyer;
                if (RD != null)
                {
                    RD.ShootLeft(gameManager);
                    RD.ShootRight(gameManager);
                }
            }
        }
        public void MonstersMove(GameManager gameManager, SpeelVeld speelVeld)
        {
            //all monsters in the playfield move in a random direction
            Random rand = new Random();
            foreach (var monster in speelVeld.AllMonsters)
            {
                int roll = rand.Next(0, 4); //4 directions
                monster.Move(roll, gameManager);
            }
        }
        public void ResultScreen(GameManager gameManager)
        {
            switch (gameManager.CurrentGameState)
            {
                case GameState.Won:
                    gameManager.WinScreen();
                    break;
                case GameState.LostByWalkingIntoMonster:
                case GameState.LostByDestroyer:
                case GameState.LostByTurnLimit:
                    gameManager.LoseScreen();
                    break;
                default:
                    break;
            }
        }
    }
}
