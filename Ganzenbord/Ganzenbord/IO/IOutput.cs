using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    interface IOutput
    {
        public void Write(string toOut);
        public void WriteLine(string toOut);
        public void Clear();
    }
}
