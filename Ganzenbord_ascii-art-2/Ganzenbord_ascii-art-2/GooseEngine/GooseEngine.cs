using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    public enum Direction { forward, backwards};
    class GooseEngine
    {
        public GooseEngine(List<GoosePiece> goosePieces)
        {
            this.goosePieces = goosePieces;
        }
        public List<GoosePiece> goosePieces { get; set; }
        public int WinningPiece { get; set; } = -1;
        private int Turn { get; set; } = 1;
        public void Start(IDisplay display, IInput input, IGooseBoard gooseBoard)
        {
            display.Clear();
            GameLoop(display, input, gooseBoard);
            input.ReadLine();
        }
        private void GameLoop(IDisplay display, IInput input, IGooseBoard gooseBoard)
        {
            display.gameboard();
            display.PiecesGameboard(goosePieces, gooseBoard);

            display.Pieces(goosePieces);
            display.Turn(Turn);
            display.EndOfTurn(WinningPiece, Turn);
            input.ReadLine();

            while (WinningPiece == -1)
            {
                display.RemovePiecesGameboard(goosePieces, gooseBoard);
                display.Turn(Turn);
                
                PlayersTurn(gooseBoard);

                display.PiecesGameboard(goosePieces, gooseBoard);
                display.TurnResult(goosePieces);

                Turn++;
                display.EndOfTurn(WinningPiece, Turn);
                input.ReadLine();
            }
        }

        
        private void PlayersTurn(IGooseBoard gooseBoard)
        {
            Random rand = new Random();
            foreach (var piece in goosePieces)
            {
                piece.UpdateState();
                if (piece.CurrentGoosePieceState == GoosePieceState.Static)
                {
                    piece.DiceRoll1 = rand.Next(1, 7);
                    piece.DiceRoll2 = rand.Next(1, 7);
                    piece.LastLocation = piece.Location;
                    DetermineNewLocation(piece, piece.DiceRoll1 + piece.DiceRoll2, Direction.forward, gooseBoard);
                }
                else
                {
                    piece.DiceRoll1 = 0;
                    piece.DiceRoll2 = 0;
                }
            }
        }

        private int DetermineNewLocation(GoosePiece GP, int roll, Direction direction, IGooseBoard gooseBoard, int totalRoll = -1)
        {
            int attemptedLocation = CalcAttemptedLocation(GP.Location, direction, roll);
            totalRoll = CalcTotalRoll(direction, roll, totalRoll);//important for goose
            int resultedLocation;

            if (GP.Location == 00 && roll == 9)
            {
                GP.CurrentGoosePieceState = GoosePieceState.Goose;
                resultedLocation = CalcSpecialResultFromStart(GP.DiceRoll1, GP.DiceRoll2);
            }
            else if (attemptedLocation < 1)
            {
                resultedLocation = 1;
            }
            else if (attemptedLocation > 63)
            {
                GP.Location = 63;
                DetermineNewLocation(GP, attemptedLocation - 63, Direction.backwards, gooseBoard, roll);
                resultedLocation = GP.Location;
            }
            else
            {
                Spaces currentSpace = gooseBoard.GooseBoardArray[attemptedLocation].CurrentSpace;
                switch (currentSpace)
                {
                    case Spaces.Static:
                        resultedLocation = attemptedLocation;
                        break;
                    case Spaces.Goose:
                        GP.CurrentGoosePieceState = GoosePieceState.Goose;
                        GP.Location = attemptedLocation;
                        resultedLocation = DetermineNewLocation(GP, totalRoll, direction, gooseBoard, totalRoll);
                        GP.JumpLocation = attemptedLocation;
                        break;
                    case Spaces.Bridge:
                        GP.CurrentGoosePieceState = GoosePieceState.Bridge;
                        resultedLocation = 12;
                        GP.JumpLocation = 6;
                        break;
                    case Spaces.Inn:
                        GP.CurrentGoosePieceState = GoosePieceState.Inn;
                        resultedLocation = attemptedLocation;
                        break;
                    case Spaces.Well:
                        ClearWell();
                        GP.CurrentGoosePieceState = GoosePieceState.Well;
                        resultedLocation = attemptedLocation;
                        break;
                    case Spaces.Maze:
                        GP.CurrentGoosePieceState = GoosePieceState.Maze;
                        resultedLocation = 39;
                        GP.JumpLocation = 42;
                        break;
                    case Spaces.Prison:
                        GP.CurrentGoosePieceState = GoosePieceState.Prison;
                        resultedLocation = attemptedLocation;
                        break;
                    case Spaces.Death:
                        GP.CurrentGoosePieceState = GoosePieceState.Death;
                        resultedLocation = 1;
                        GP.JumpLocation = 58;
                        break;
                    case Spaces.End:
                        resultedLocation = 63;
                        WinningPiece = GP.PieceID;
                        break;
                    default:
                        resultedLocation = attemptedLocation;
                        break;
                }
            }

            GP.Location = resultedLocation;
            return resultedLocation;
        }

        private void ClearWell()
        {
            foreach (var piece in goosePieces)
            {
                if (piece.CurrentGoosePieceState == GoosePieceState.Well)
                {
                    piece.CurrentGoosePieceState = GoosePieceState.Static;
                }
            }
        }

        private int CalcSpecialResultFromStart(int diceRoll1, int diceRoll2)
        {
            if (diceRoll1 == 5 || diceRoll2 == 5)
            {
                return 26;
            }
            else
            {
                return 53;
            }
        }

        private int CalcTotalRoll(Direction direction, int roll, int totalRoll)
        {
            //change totalRoll to be equal to roll when direction is forward
            if (direction == Direction.forward)
            {
                return roll; 
            }
            else
            {
                return totalRoll;
            }
        }

        private int CalcAttemptedLocation(int location, Direction direction, int roll)
        {
            if (direction == Direction.forward)
            {
                return location + roll;
            }
            else
            {
                return location - roll;
            }
        }
    }
}
