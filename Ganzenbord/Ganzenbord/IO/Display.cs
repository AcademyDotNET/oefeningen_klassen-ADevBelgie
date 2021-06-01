using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class Display: IDisplay
    {
        public Display(IOutput output)
        {
            DisplayOutput = output;
        }
        public IOutput DisplayOutput { get; set; }
        public void Clear()
        {
            DisplayOutput.Clear();
        }
        public void Welcome()
        {
            DisplayOutput.Clear();
            DisplayOutput.WriteLine("Welcome To a Game of Goose");
        }
        public void End()
        {
            DisplayOutput.Clear();
            DisplayOutput.WriteLine("Congratgulations on winning");
        }
        public void Location(int jumpLocation, int location)
        {
            if (jumpLocation != -1)
            {
                DisplayOutput.Write($"{jumpLocation} -> {location}");
            }
            else
            {
                DisplayOutput.Write($"{location}\t");
            }
        }
        public void CurrentGoosePieceState(GoosePieceState currentGoosePieceState)
        {
            DisplayOutput.Write($"{currentGoosePieceState} ");
        }
        public void RolledDice(int diceRoll1, int diceRoll2)
        {
            if (diceRoll1 == 0)
            {
                DisplayOutput.Write($"\t");
            }
            else
            {
                DisplayOutput.Write($"\t{diceRoll1}+{diceRoll2}: ");
            }
        }
        public void Turn(int turn)
        {
            DisplayOutput.WriteLine($"\nTurn {turn}");
        }
        public void Pieces(List<GoosePiece> goosePieces)
        {
            foreach (var piece in goosePieces)
            {
                DisplayOutput.Write($"\tPIECE {piece.PieceID}\t\t");
            }
        }
        public void EndOfTurn(int winningPiece, int turn)
        {
            if (winningPiece == -1)
            {
                DisplayOutput.WriteLine($"\n\n[PRESS ENTER TO PLAY TURN {turn}]");
            }
            else
            {
                DisplayOutput.WriteLine($"\n\n[PRESS ENTER TO FINISH GAME]");
            }
        }
    }
    
}
