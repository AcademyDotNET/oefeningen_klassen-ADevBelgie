using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    class Input:IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public int ReadLineNumber()
        {
            IOutput output = new Output();
            string inputUser = ReadLine();
            int returnValue;
            while (!Int32.TryParse(inputUser, out returnValue))
            {
                output.WriteLine("Please give a valid number");
                inputUser = ReadLine();
            }
            return returnValue;
        }
    }
}
