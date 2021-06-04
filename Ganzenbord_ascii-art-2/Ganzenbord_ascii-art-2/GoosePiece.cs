using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    public enum GoosePieceState { Inn, Well, Prison, Static, Death, Bridge, Maze, Goose }
    class GoosePiece
    {
        public GoosePiece(int pieceID)
        {
            PieceID = pieceID;
        }
        public int PieceID { get; set; }
        public ConsoleColor PieceColor { get; set; }
        public int Location { get; set; } = 0;
        public int LastLocation { get; set; }
        public int JumpLocation { get; set; } = -1;
        public int DiceRoll1 { get; set; }
        public int DiceRoll2 { get; set; }
        public int TurnsInAbnormalState { get; set; } = 0;
        public GoosePieceState CurrentGoosePieceState { get; set; } = GoosePieceState.Static;
        public void UpdateState()
        {
            JumpLocation = -1;
            switch (CurrentGoosePieceState)
            {
                case GoosePieceState.Inn:
                    if (TurnsInAbnormalState >= 1)
                    {
                        CurrentGoosePieceState = GoosePieceState.Static;
                        TurnsInAbnormalState = 0;
                    }
                    else
                    {
                        TurnsInAbnormalState++;
                    }
                    break;
                case GoosePieceState.Prison:
                    if (TurnsInAbnormalState >= 3)
                    {
                        CurrentGoosePieceState = GoosePieceState.Static;
                        TurnsInAbnormalState = 0;
                    }
                    else
                    {
                        TurnsInAbnormalState++;
                    }
                    break;
                case GoosePieceState.Well:
                    break;
                default:
                    CurrentGoosePieceState = GoosePieceState.Static;
                    break;
            }
        }
    }
}
