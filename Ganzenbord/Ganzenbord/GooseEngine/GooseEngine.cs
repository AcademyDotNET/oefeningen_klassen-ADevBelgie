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
            GooseBoard gooseMap = new GooseBoard();

            output.Clear();
            GameLoop(gooseMap);
            input.ReadLine();
        }
        private void GameLoop(GooseBoard gooseMap)
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
                PlayersTurn(gooseMap);
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
        private void PlayersTurn(GooseBoard gooseMap)
        {
            Random rand = new Random();
            foreach (var item in goosePieces)
            {
                item.UpdateState();
                if (item.CurrentGoosePieceState == GoosePieceState.Normal)
                {
                    item.DiceRoll1 = rand.Next(1, 7);
                    item.DiceRoll2 = rand.Next(1, 7);
                    DetermineNewLocation(item, item.DiceRoll1 + item.DiceRoll2, Direction.forward, gooseMap);
                }
                else
                {
                    item.DiceRoll1 = 0;
                    item.DiceRoll2 = 0;
                }
            }
        }
        private int DetermineNewLocation(GoosePiece GP, int roll, Direction direction, GooseBoard gooseMap, int totalRoll = -1)
        {
            int attemptedLocation;
            if (direction == Direction.forward)
            {
                attemptedLocation = GP.Location + roll;
            }
            else
            {
                attemptedLocation = GP.Location - roll;
            }
               
            int resultedLocation;
            if (direction == Direction.forward)
            {
                totalRoll = roll;
            }

            if (attemptedLocation < 1)
            {
                resultedLocation = 1;
            }
            else if (attemptedLocation > 63)
            {
                GP.Location = 63;
                DetermineNewLocation(GP, attemptedLocation - 63, Direction.backwards, gooseMap, roll);
                resultedLocation = GP.Location;
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
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.End)
            {
                resultedLocation = 63;
                WinningPiece = GP.PieceID;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Static)
            {
                resultedLocation = attemptedLocation;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Goose)
            {
                GP.Location = attemptedLocation;
                resultedLocation = DetermineNewLocation(GP, totalRoll, direction, gooseMap, totalRoll);
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Bridge)
            {
                resultedLocation = 12;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Maze)
            {
                resultedLocation = 39;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Death)
            {
                resultedLocation = 0;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Inn)
            {
                GP.CurrentGoosePieceState = GoosePieceState.Inn;
                resultedLocation = attemptedLocation;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Prison)
            {
                GP.CurrentGoosePieceState = GoosePieceState.Prison;
                resultedLocation = attemptedLocation;
            }
            else if (gooseMap.GooseBoardArray[attemptedLocation].CurrentSpace == Spaces.Well)
            {
                foreach (var piece in goosePieces)
                {
                    if (piece.CurrentGoosePieceState == GoosePieceState.Well)
                    {
                        piece.CurrentGoosePieceState = GoosePieceState.Normal;
                    }
                }
                GP.CurrentGoosePieceState = GoosePieceState.Well;
                resultedLocation = attemptedLocation;
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
