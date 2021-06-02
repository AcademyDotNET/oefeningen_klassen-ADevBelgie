using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class Output :IOutput
    {
        public void Write(string toOut)
        {
            Console.Write(toOut);
        }
        public void WriteLine(string toOut)
        {
            Console.WriteLine(toOut);
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
