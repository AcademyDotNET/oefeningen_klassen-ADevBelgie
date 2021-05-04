using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum GameState { GameInProgress, Won, LostByDestroyer, LostByWalkingIntoMonster, LostByTurnLimit, LostByError, ExitGameInProgress}
    class SpeelVeld
    {
        public SpeelVeld()
        {
            InitGame();
            InitSpeelVeld(Array);
        }
        public SpeelVeld(int chanceOfMonsters)
        {
            InitGame();
            InitSpeelVeld(Array, chanceOfMonsters);
        }

        //speelveld array van [20, 20]
        private int arrayRows;
        private int arrayColumns;
        public MapElement[,] Array { get; set; }

        //Player location, start location is [0, 10]
        public Point PlayerLocation { get; set; }
        public List<Monster> AllMonsters { get; set; }

        //CurrentGameState on game start = GameState.GameInProgress
        public GameState CurrentGameState { get; set; }

        //game score
        public Score GameScore { get; set; }

        private void InitGame()
        {
            CurrentGameState = GameState.GameInProgress;
            GameScore = new Score();
            arrayRows = 20;
            arrayColumns = 20;
            Array = new MapElement[arrayRows, arrayColumns];
            AllMonsters = new List<Monster>();
        }
        private void InitSpeelVeld(MapElement[,] speelVeld, int chanceOfMonsters = 5)
        {
            //generate monsters, rocks & empty spaces
            Random rand = new Random();
            for (int row = 0; row < speelVeld.GetLength(0); row++)
            {
                for (int col = 0; col < speelVeld.GetLength(1); col++)
                {
                    int genElement = rand.Next(1,4);
                    switch (genElement)
                    {
                        case 1:
                            genElement = rand.Next(0, chanceOfMonsters);
                            if (genElement == 0)
                                { 
                                    speelVeld[row, col] = new Monster(row, col);
                                    AllMonsters.Add((Monster)speelVeld[row, col]);
                                }
                            else
                                { speelVeld[row, col] = new Leeg(row, col); }
                            break;
                        case 2:
                            speelVeld[row, col] = new Leeg(row, col);
                            break;
                        case 3:
                            speelVeld[row, col] = new Rock(row, col);
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate Rockdestroyer
            Remove(10, 10); //remove potential monster from the list
            speelVeld[10, 10] = new RockDestroyer(10, 10);
            AllMonsters.Add((Monster)speelVeld[10, 10]);

            //generate player
            PlayerLocation = new Point() { X = 0, Y = 10 };
            Remove(0, 10); //remove potential monster from the list
            speelVeld[0, 10] = new Player() { Location = PlayerLocation};
        }

        private void Remove(int row, int col)
        {
            //replaces mapelement with Leeg element
            if (col > 0 && col < Array.GetLength(1) && row > 0 && row < Array.GetLength(0))
            {
                if (Array[row, col].DitElement == SoortElement.Player)
                {
                    CurrentGameState = GameState.LostByError; 
                }
                else if (Array[row, col].DitElement == SoortElement.Monster) //het is niet mogelijk een rockdestroyer te doden
                {
                    AllMonsters.RemoveAll(m => m.Location.X == row && m.Location.Y == col); //remove monster in monster list 
                }
                Array[row, col] = new Leeg(row, col);
            }
        }

        public void MoveMonsters()
        {
            //all monsters in the playfield move in a random direction
            Random rand = new Random();
            foreach (var monster in AllMonsters)
            {
                int roll = rand.Next(0,4); //4 directions
                switch (roll)
                {
                    case 0://Boven
                        monster.MoveUp(this);
                        break;
                    case 1://Onder
                        monster.MoveDown(this);
                        break;
                    case 2://links
                        monster.MoveLeft(this);
                        break;
                    case 3://rechts
                        monster.MoveRight(this);
                        break;
                    default:
                        break;
                }
            }
        }
        public void ShootMonsters()
        {
            //makes the rockdetroyer shoot
            for (int i = 0; i < AllMonsters.Count; i++)
            {
                RockDestroyer RD = AllMonsters[i] as RockDestroyer;
                if (RD != null)
                {
                    RD.ShootLeft(this);
                    RD.ShootRight(this);
                }
            }
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
            Console.WriteLine("You won the game");
            Console.WriteLine($"\nTurns elapsed: {GameScore.GameTurns}");
            Console.WriteLine($"Shots fired: {GameScore.ShotsFired}");
            Console.WriteLine($"Monsters killed: {GameScore.MonstersKilled}");
            Console.WriteLine($"Rocks destroyed: {GameScore.RockDestroyed}");
            Console.WriteLine($"Accuracy: {(GameScore.ShotsFired != 0?((GameScore.MonstersKilled + GameScore.RockDestroyed) / GameScore.ShotsFired )*100:100)}%");
            Console.WriteLine($"\nScore: {GameScore}");
            Console.WriteLine($"\nTurns elapsed has the biggest influence on the score");
            //add to highscore (BP - 7143)
            System.Threading.Thread.Sleep(200);
        }

        public override string ToString()
        {
            string playFieldString = "";
            for (int i = 0; i < arrayRows; i++)
            {
                for (int y = 0; y < arrayColumns; y++)
                {
                    if (Array[i, y].DitElementChar != SoortElementChar.L)
                    {
                        playFieldString += Array[i, y].DitElementChar + " ";
                    }
                    else
                    {
                        playFieldString += "  ";
                    }
                }
                playFieldString += "\n";
            }
            playFieldString += "+ + + + + + + +         + + + + + + + +\n";
            return playFieldString;
        }
    }
}
