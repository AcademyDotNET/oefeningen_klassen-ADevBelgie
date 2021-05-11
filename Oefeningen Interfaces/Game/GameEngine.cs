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
            //init interfaces
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();
            output.Clear();

            //init game settings and map elements
            GameInfo gameInfo = new GameInfo();
            gameInfo.DisplayInfo(gameManager.Settings);
            SpeelVeld speelVeld = new SpeelVeld(gameManager.Settings.Difficulty);
            Player player1 = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];
            gameManager.CurrentGameState = GameState.GameInProgress;

            // Game loop
            while (gameManager.CurrentGameState == GameState.GameInProgress)
            {
                output.WriteSpeelveld(speelVeld, gameManager.Settings);

                // Get user key and perform action
                input.GetKey();
                if (input.UserInputKey == gameManager.Settings.MoveUpKey)
                {
                    player1.MoveUp(speelVeld, gameManager);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveDownKey)
                {
                    player1.MoveDown(speelVeld, gameManager);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveRightKey)
                {
                    player1.MoveRight(speelVeld, gameManager);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveLeftKey)
                {
                    player1.MoveLeft(speelVeld, gameManager);
                }
                else if (input.UserInputKey == gameManager.Settings.ShootRightKey)
                {
                    gameManager.GameScore.ShotsFired++;
                    player1.ShootRight(speelVeld, gameManager);
                }
                else if (input.UserInputKey == gameManager.Settings.ShootLeftKey)
                {
                    gameManager.GameScore.ShotsFired++;
                    player1.ShootLeft(speelVeld, gameManager);
                }
                else if (input.UserInputKey == input.Escape)
                {
                    gameManager.CurrentGameState = GameState.ExitGameInProgress;
                }

                //monsters turn
                speelVeld.MoveMonsters();
                speelVeld.ShootMonsters(gameManager);

                gameManager.GameScore.GameTurns++;
                if (gameManager.GameScore.GameTurns >= 150)
                {
                    gameManager.CurrentGameState = GameState.LostByTurnLimit;
                }
                output.ClearSpeelveld(speelVeld);
            }

            // game over result screen
            output.Clear();
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

            //if end of game return true, the PlayGame method will be called again
            return gameManager.EndOfGameEngine();
        }
    }
}
