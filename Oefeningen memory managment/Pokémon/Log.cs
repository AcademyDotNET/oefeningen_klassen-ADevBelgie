using System;
using System.Collections.Generic;
using System.Text;

namespace Pokémon
{
    class Log : ILog
    {
        public void WriteLine(string toPrint = "")
        {
            Console.WriteLine(toPrint);
        }
    }
}
