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
        public void Location(int jumpLocation, int location);
        public void CurrentGoosePieceState(GoosePieceState currentGoosePieceState);
        public void RolledDice(int diceRoll1, int diceRoll2);
        public void Turn(int turn);
        public void Pieces(List<GoosePiece> goosePieces);
        public void EndOfTurn(int winningPiece, int turn);
        void gameboard();
    }
}
