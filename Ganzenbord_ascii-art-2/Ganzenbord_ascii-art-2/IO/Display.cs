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
                DisplayOutput.WriteLine($"\n\n");
                DisplayOutput.Write("\t");
                for (int i = 1; i < winningPiece; i++)
                {
                    DisplayOutput.Write("\t\t\t");
                }
                DisplayOutput.WriteLine("Winner!!!");
                DisplayOutput.WriteLine($"[PRESS ENTER TO FINISH GAME]");
            }
        }

//        public void gameboard()
//        {
//            DisplayOutput.WriteLine(@$"                          ____        ____        ____        ____        ____
//                         /    \      /    \      /    \      /    \      /    \
//                    ____/      \____/      \____/      \____/      \____/      \____
//                   /    \  27  /    \  25  /    \  23  /    \  21  /    \  19  /    \
//              ____/      \____/      \____/      \____/      \____/      \____/      \____
//             /    \  28  /    \  26  /    \  24  /    \  22  /    \  20  /    \  18  /    \
//        ____/      \____/      \____/      \____/      \____/      \____/      \____/      \____
//       /    \  29  /    \  59  /    \  57  /    \  55  /    \  53  /    \  51  /    \  17  /    \
//  ____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____
// /    \  30  /    \  60  /    \  58  /    \  56  /    \  54  /    \  52  /    \  50  /    \  16  /    \
///      \____/      \____/      \____/      \____/_   __\____/      \____/      \____/      \____/      \
//\  31  /    \  61  /                            / ) (__ )                           \  49  /    \  15  /
// \____/      \____/                            / _ \ (_ \                            \____/      \____/
// /    \  62  /                                 \___/(___/                            /    \  48  /    \
///      \____/       ____        ____        ____        ____        ____        ____/      \____/      \
//\  32  /    \      /    \      /    \      /    \      /    \      /    \      /    \  47  /    \  14  /
// \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/
//      \  33  /    \  35  /    \  37  /    \  39  /    \  41  /    \  43  /    \  46  /    \  13  /
//       \____/      \____/      \____/      \____/      \____/      \____/      \____/      \____/
//       [  ^#\  34  /    \  36  /    \  38  /    \  40  /    \  42  /    \  45  /    \  12  /
//  _._,.[    ^\____/      \____/      \____/      \____/      \____/      \____/      \____/
// |              ^#\   1  /    \   3  /    \   5  /    \   7  /    \   9  /    \  11  /
// ]       START    ^\____/      \____/      \____/      \____/      \____/      \____/
// |.,_,,.          ./    \   2  /    \   4  /    \   6  /    \   8  /    \  10  /
//       [         #       \____/      \____/      \____/      \____/      \____/
//       [     _&*^
//       [__,$*");
//        }
    }
    
}
