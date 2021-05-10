﻿using System;
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
            

            // Game loop
            while (speelVeld.CurrentGameState == GameState.GameInProgress)
            {
                output.WriteSpeelveld(speelVeld, gameManager.Settings);

                // Get user key and perform action
                input.GetKey();
                if (input.UserInputKey == gameManager.Settings.MoveUpKey)
                {
                    player1.MoveUp(speelVeld);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveDownKey)
                {
                    player1.MoveDown(speelVeld);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveRightKey)
                {
                    player1.MoveRight(speelVeld);
                }
                else if (input.UserInputKey == gameManager.Settings.MoveLeftKey)
                {
                    player1.MoveLeft(speelVeld);
                }
                else if (input.UserInputKey == gameManager.Settings.ShootRightKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootRight(speelVeld);
                }
                else if (input.UserInputKey == gameManager.Settings.ShootLeftKey)
                {
                    speelVeld.GameScore.ShotsFired++;
                    player1.ShootLeft(speelVeld);
                }
                else if (input.UserInputKey == ConsoleKey.Escape)
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
                output.ClearSpeelveld(speelVeld);
            }

            // game over result screen
            output.Clear();
            switch (speelVeld.CurrentGameState)
            {
                case GameState.Won:
                    speelVeld.WinScreen(gameManager.HiScores);
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
            return gameManager.EndOfGame(gameManager.Settings);
        }
    }
}
