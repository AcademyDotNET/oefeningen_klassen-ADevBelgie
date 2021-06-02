using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    class GooseManager
    {
        public void Start()
        {
            IInput input = new Input();
            IOutput output = new Output();//how to output something
            IDisplay display = new Display(output);//what to output
            IGooseBoard gooseBoard = new GooseBoard();
            List<GoosePiece> goosePieces = new List<GoosePiece>();

            display.Welcome();

            MakeListPieces(goosePieces, GetAmountOfPieces(input, output));
            GooseEngine GE = new GooseEngine(goosePieces);
            GE.Start(display, input, gooseBoard);

            display.End();
            input.ReadLine();
        }
        public void MakeListPieces(List<GoosePiece> goosePieces, int amountOfPieces)
        {
            for (int i = 0; i < amountOfPieces; i++)
            {
                goosePieces.Add(new GoosePiece(i + 1));
            }
        }
        private int GetAmountOfPieces(IInput input, IOutput output)
        {
            output.WriteLine("How many pieces will participate?(2-4)");

            int amountOfPieces;
            amountOfPieces = input.ReadLineNumber();
            while (amountOfPieces>4 || amountOfPieces<2)
            {
                output.WriteLine("Please give a number between 2-4");
                amountOfPieces = input.ReadLineNumber();
            }
            
            return amountOfPieces;
        }
    }
}
