using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    interface IDisplay
    {
        public IOutput DisplayOutput { get; set; }
        public void Clear();
        public void Welcome();
        public void End();
        public void Turn(int turn);
        public void Pieces(List<GoosePiece> goosePieces);
        public void EndOfTurn(int winningPiece, int turn);
        public void gameboard();
        public void PiecesGameboard(List<GoosePiece> goosePieces, IGooseBoard gooseBoard);
        public void RemovePiecesGameboard(List<GoosePiece> goosePieces, IGooseBoard gooseBoard);
        public void TurnResult(List<GoosePiece> goosePieces);
    }
}
