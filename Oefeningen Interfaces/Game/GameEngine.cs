using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameEngine
    {
        GameManager gameManager;
        public GameEngine(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }
        public bool Start()
        {
            // Init game
            InitGameScreen();
            gameManager.GameScore = new Score();
            SpeelVeld speelVeld = new SpeelVeld(gameManager);
            Player player = (Player)speelVeld.Array[speelVeld.PlayerLocation.X, speelVeld.PlayerLocation.Y];
            gameManager.CurrentGameState = GameState.GameInProgress;

            // Game loop
            while (gameManager.CurrentGameState == GameState.GameInProgress)
            {
                WriteGameField(speelVeld);
                
                // Get user key and perform action
                UserTurn(speelVeld, player);

                // monsters move in random direction & RockDestroyer schiet
                MonsterTurn(speelVeld);

                gameManager.GameScore.GameTurns++;
                if (gameManager.GameScore.GameTurns >= 150)
                {
                    gameManager.CurrentGameState = GameState.LostByTurnLimit;
                }
            }

            // Result screen
            ResultScreen();
            
            // if end of game return true, the PlayGame method will be called again
            return gameManager.EndOfGameEngine();
        }
        public void InitGameScreen()
        {
            IUserOutput output = new UserOutput();

            output.Clear();
            GameInfo gameInfo = new GameInfo();
            gameInfo.DisplayInfo(gameManager.Settings);
        }
        public void WriteGameField(SpeelVeld speelVeld)
        {
            IUserOutput output = new UserOutput();

            output.ClearSpeelveld(speelVeld);
            output.WriteSpeelveld(speelVeld, gameManager.Settings);
        }
        public void UserTurn(SpeelVeld speelVeld, Player player)
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            input.GetKey();
            if (input.UserInputKey == gameManager.Settings.MoveUpKey)
            {
                player.Move(0);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveRightKey)
            {
                player.Move(1);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveDownKey)
            {
                player.Move(2);
            }
            else if (input.UserInputKey == gameManager.Settings.MoveLeftKey)
            {
                player.Move(3);
            }
            else if (input.UserInputKey == gameManager.Settings.ShootRightKey)
            {
                gameManager.GameScore.ShotsFired++;
                player.ShootRight();
            }
            else if (input.UserInputKey == gameManager.Settings.ShootLeftKey)
            {
                gameManager.GameScore.ShotsFired++;
                player.ShootLeft();
            }
            else if (input.UserInputKey == input.Escape)
            {
                gameManager.CurrentGameState = GameState.ExitGameInProgress;
            }
        }
        public void MonsterTurn(SpeelVeld speelVeld)
        {
            MonstersMove(speelVeld);
            MonstersSchoot(speelVeld);
        }
        public void MonstersSchoot(SpeelVeld speelVeld)
        {
            //makes the rockdetroyer shoot
            for (int i = 0; i < speelVeld.AllMonsters.Count; i++)
            {
                RockDestroyer RD = speelVeld.AllMonsters[i] as RockDestroyer;
                if (RD != null)
                {
                    RD.ShootLeft();
                    RD.ShootRight();
                }
            }
        }
        public void MonstersMove(SpeelVeld speelVeld)
        {
            //all monsters in the playfield move in a random direction
            Random rand = new Random();
            foreach (var monster in speelVeld.AllMonsters)
            {
                int roll = rand.Next(0, 4); //4 directions
                monster.Move(roll);
            }
        }
        public void ResultScreen()
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
