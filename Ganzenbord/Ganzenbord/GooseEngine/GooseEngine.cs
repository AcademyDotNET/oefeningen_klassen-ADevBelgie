using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    public enum Direction { forward, backwards};
    class GooseEngine
    {
        public GooseEngine(int amountOfPieces)
        {
            for (int i = 0; i < amountOfPieces; i++)
            {
                goosePieces.Add(new GoosePiece(i + 1));
            }
        }
        public List<GoosePiece> goosePieces { get; set; } = new List<GoosePiece>();
        public int WinningPiece { get; set; } = -1;
        private int Turn { get; set; } = 1;
        public void Start()
        {
            IOutput output = new Output();
            IInput input = new Input();
            GooseMap gooseMap = new GooseMap();

            output.Clear();
            GameLoop(gooseMap);
            input.ReadLine();
        }
        private void GameLoop(GooseMap gooseMap)
        {
            IOutput output = new Output();
            IInput input = new Input();

            while (WinningPiece == -1)
            {
                foreach (var item in goosePieces)
                {
                    output.Write($"\tPIECE {item.PieceID}\t");
                }
                output.WriteLine($"\nTurn {Turn}");
                Turn++;
                RollDice(gooseMap);
                foreach (var item in goosePieces)
                {
                    output.Write($"\t{item.DiceRoll1}+{item.DiceRoll2}: {item.Location}\t");
                }
                if (WinningPiece == -1)
                {
                    output.WriteLine($"\n\n[PRESS ENTER TO PLAY TURN {Turn}]");
                }
                else
                {
                    output.WriteLine($"\n\n[PRESS ENTERTO FINISH GAME]");
                }

                input.ReadLine();
            }
        }
        private void RollDice(GooseMap gooseMap)
        {
            Random rand = new Random();
            foreach (var item in goosePieces)
            {
                item.DiceRoll1 = rand.Next(1, 7);
                item.DiceRoll2 = rand.Next(1, 7);
                DetermineNewLocation(item, item.DiceRoll1 + item.DiceRoll2, Direction.forward, gooseMap);
            }
        }
        private int DetermineNewLocation(GoosePiece GP, int roll, Direction direction, GooseMap gooseMap, int totalRoll = -1)
        {
            int attemptedLocation = GP.Location + roll;
            int resultedLocation;
            if (direction == Direction.forward)
            {
                totalRoll = roll;
            }

            
            else if (GP.Location == 00 && roll == 9)
            {
                if (GP.DiceRoll1 == 5 || GP.DiceRoll1 == 5)
                {
                    resultedLocation = 26;
                }
                else
                {
                    resultedLocation = 53;
                }
            }
            else if (attemptedLocation > 63)
            {
                GP.Location = 63;
                DetermineNewLocation(GP, 63-attemptedLocation, Direction.backwards, gooseMap, roll);
                resultedLocation = GP.Location;
            }
            if (gooseMap.GooseBoard[attemptedLocation - 1].CurrentSpace == Spaces.End)
            {
                resultedLocation = 63;
                WinningPiece = GP.PieceID;
            }
            else if (gooseMap.GooseBoard[attemptedLocation-1].CurrentSpace == Spaces.Static)
            {
                resultedLocation = attemptedLocation;
            }
            else if (gooseMap.GooseBoard[attemptedLocation-1].CurrentSpace == Spaces.Goose)
            {
                GP.Location = attemptedLocation;
                resultedLocation = DetermineNewLocation(GP, totalRoll, direction, gooseMap);
            }
            else
            {
                resultedLocation = attemptedLocation;
            }

            GP.Location = resultedLocation;
            return resultedLocation;
        }
    }
}
