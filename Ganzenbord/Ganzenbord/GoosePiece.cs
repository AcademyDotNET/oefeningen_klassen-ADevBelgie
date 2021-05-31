using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class GoosePiece
    {
        public GoosePiece(int pieceID)
        {
            PieceID = pieceID;
        }
        public int PieceID { get; set; }
        public int Location { get; set; } = 0;
        public int DiceRoll1 { get; set; }
        public int DiceRoll2 { get; set; }
    }
}
