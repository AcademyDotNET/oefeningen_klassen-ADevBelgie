using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class GooseManager
    {
        public void Start()
        {
            Welcome();
            GooseEngine GE = new GooseEngine(GetAmountOfPieces());
            GE.Start();
            End();
        }

        private int GetAmountOfPieces()
        {
            IOutput output = new Output();
            IInput input = new Input();

            output.WriteLine("How many pieces will participate?(1-4)");

            int amountOfPieces;
            amountOfPieces = input.ReadLineNumber();
            while (amountOfPieces>4 || amountOfPieces<1)
            {
                output.WriteLine("Please give a number between 1-4");
                amountOfPieces = input.ReadLineNumber();
            }
            
            return amountOfPieces;
        }

        private void End()
        {
            IOutput output = new Output();
            IInput input = new Input();

            output.Clear();
            output.WriteLine("Congratgulations on winning");
            input.ReadLine();
        }

        private void Welcome()
        {
            IOutput output = new Output();
            output.Clear();
            output.WriteLine("Welcome To a Game of Goose");
        }
    }
}
