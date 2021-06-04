using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
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
        public void ClearLine()
        {
            DisplayOutput.SetCursorPosition(0, DisplayOutput.GetCursorPosition().Item2);
            DisplayOutput.Write("                                                                                                                 ");
            DisplayOutput.SetCursorPosition(0, DisplayOutput.GetCursorPosition().Item2);
        }
        public void Welcome()
        {
            DisplayOutput.Clear();
            DisplayOutput.WriteLine("Welcome To a Game of Goose");
            DisplayOutput.WriteLine(@$"                                   ___
                               ,-""   `.
                             ,'  _   e )`-._
                            /  ,' `-._<.===-'
                           /  /
                          /  ;
              _          /   ;
 (`._    _.-"" ""--..__,'    |
 <_  `-""                     \
  <`-                          :
   (__   <__.                  ;
     `-.   '-.__.      _.'    /
        \      `-.__,-'    _,'
         `._    ,    /__,-'
            ""._\__,'< <____
                 | |  `----.`.
                 | |        \ `.
                 ; |___      \-``
                 \   --<
                  `.`.<
                    `-'");
        }
        public void End()
        {
            DisplayOutput.Clear();
            DisplayOutput.WriteLine("Congratgulations on winning");
        }
        public void Turn(int turn)
        {
            DisplayOutput.SetCursorPosition(0, 30);
            ClearLine();
            DisplayOutput.WriteLine($"Turn {turn}");
        }
        public void Pieces(List<GoosePiece> goosePieces)
        {
            DisplayOutput.SetCursorPosition(0, 29);
            ClearLine();
            foreach (var piece in goosePieces)
            {
                DisplayOutput.Write($"\tPIECE {piece.PieceID}\t\t");
            }
        }
        public void EndOfTurn(int winningPiece, int turn)
        {
            //needs to be at line 36
            DisplayOutput.SetCursorPosition(0, 36);
            ClearLine();
            if (winningPiece == -1)
            {
                DisplayOutput.WriteLine($"[PRESS ENTER TO PLAY TURN {turn}]");
            }
            else
            {
                DisplayOutput.Write("\t");
                for (int i = 1; i < winningPiece; i++)
                {
                    DisplayOutput.Write("\t\t\t");
                }
                DisplayOutput.WriteLine("Winner!!!");
                DisplayOutput.WriteLine($"[PRESS ENTER TO FINISH GAME]");
            }
        }

        public void gameboard()
        {
            DisplayOutput.WriteLine(@$"                          ____        ____        ____        ____        ____
                         /    \      /    \      /    \      /    \      /    \
                    ____/      \____/      \____/      \____/      \____/      \____
                   /    \  27  /    \  25  /    \  23  /    \  21  /    \  19  /    \
              ____/      \____/      \____/      \____/      \____/      \____/      \____
             /    \  28  /    \  26  /    \  24  /    \  22  /    \  20  /    \  18  /    \
        ____/      \____/      \____/      \____/      \____/      \____/      \____/      \____
       /    \  29  /    \  58  /    \  56  /    \  54  /    \  52  /    \  50  /    \  17  /    \
  ____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____
 /    \  30  /    \  59  /    \  57  /    \  55  /    \  53  /    \  51  /    \  49  /    \  16  /    \
/      \____/      \____/      \____/      \____/_   __\____/      \____/      \____/      \____/      \
\  31  /    \  60  /                            / ) (__ )                           \  48  /    \  15  /
 \____/      \____/                            / _ \ (_ \                            \____/      \____/
 /    \  61  /    \                            \___/(___/                            /    \  47  /    \
/      \____/      \____        ____        ____        ____        ____        ____/      \____/      \
\  32  /    \  62  /    \      /    \      /    \      /    \      /    \      /    \  46  /    \  14  /
 \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/
      \  33  /    \  35  /    \  37  /    \  39  /    \  41  /    \  43  /    \  45  /    \  13  /
       \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/
       [  ^#\  34  /    \  36  /    \  38  /    \  40  /    \  42  /    \  44  /    \  12  /
  _._,.[    ^\____/      \____/      \____/      \____/      \____/      \____/      \____/
 |              ^#\   1  /    \   3  /    \   5  /    \   7  /    \   9  /    \  11  /
 ]                ^\____/      \____/      \____/      \____/      \____/      \____/
 |.,_,,.  START   ./    \   2  /    \   4  /    \   6  /    \   8  /    \  10  /
       [        .#       \____/      \____/      \____/      \____/      \____/
       [     _&*^
       [__,$*");
        }

        public void PiecesGameboard(List<GoosePiece> goosePieces, IGooseBoard gooseBoard)
        {
            for (int i = 0; i < goosePieces.Count; i++)
            {
                DisplayOutput.SetCursorPosition(
                    gooseBoard.GooseBoardArray[goosePieces[i].Location].Location.X+i, 
                    gooseBoard.GooseBoardArray[goosePieces[i].Location].Location.Y);
                DisplayOutput.ForegroundColor(goosePieces[i].PieceColor);
                DisplayOutput.BackgroundColor(ConsoleColor.White);
                DisplayOutput.Write(Convert.ToString(goosePieces[i].PieceID));
                DisplayOutput.ForegroundColor(ConsoleColor.Gray);
                DisplayOutput.BackgroundColor(ConsoleColor.Black);
            }
        }
        public void RemovePiecesGameboard(List<GoosePiece> goosePieces, IGooseBoard gooseBoard)
        {
            for (int i = 0; i < goosePieces.Count; i++)
            {
                DisplayOutput.SetCursorPosition(
                    gooseBoard.GooseBoardArray[goosePieces[i].Location].Location.X + i,
                    gooseBoard.GooseBoardArray[goosePieces[i].Location].Location.Y);
                DisplayOutput.ForegroundColor(ConsoleColor.Black);
                DisplayOutput.BackgroundColor(ConsoleColor.Black);
                DisplayOutput.Write(Convert.ToString(goosePieces[i].PieceID));
                DisplayOutput.ForegroundColor(ConsoleColor.Gray);
            }
        }

        public void TurnResult(List<GoosePiece> goosePieces)
        {
            //needs to be at line 31
            DisplayOutput.SetCursorPosition(0, 31);
            ClearLine();
            foreach (var piece in goosePieces)
            {
                if (piece.LastLocation < 10)
                {
                    DisplayOutput.Write($"\tFrom: {piece.LastLocation}\t\t");
                }
                else
                {
                    DisplayOutput.Write($"\tFrom: {piece.LastLocation}\t");
                }
                
            }
            //needs to be at line 32
            DisplayOutput.SetCursorPosition(0, 32);
            ClearLine();
            foreach (var piece in goosePieces)
            {
                RolledDice(piece.DiceRoll1, piece.DiceRoll2);
            }
            //needs to be at line 33
            DisplayOutput.SetCursorPosition(0, 33);
            ClearLine();
            foreach (var piece in goosePieces)
            {
                CurrentGoosePieceState(piece.CurrentGoosePieceState);
            }
            //needs to be at line 34
            DisplayOutput.SetCursorPosition(0, 34);
            ClearLine();
            foreach (var piece in goosePieces)
            {
                Location(piece.JumpLocation, piece.Location);
            }
        }
        private void RolledDice(int diceRoll1, int diceRoll2)
        {
            if (diceRoll1 == 0)
            {
                DisplayOutput.Write($"\t\t\t");
            }
            else
            {
                DisplayOutput.Write($"\tDice: {diceRoll1}+{diceRoll2}\t");
            }
        }
        private void CurrentGoosePieceState(GoosePieceState currentGoosePieceState)
        {
            DisplayOutput.Write($"\t{currentGoosePieceState}\t\t");
        }
        private void Location(int jumpLocation, int location)
        {
            DisplayOutput.Write($"\t");
            if (jumpLocation != -1)
            {
                DisplayOutput.Write($"{jumpLocation} -> {location}");
            }
            else
            {
                DisplayOutput.Write($"{location}");
            }
            DisplayOutput.Write($"\t\t");
        }
    }
    
}
