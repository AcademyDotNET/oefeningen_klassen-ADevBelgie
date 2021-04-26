using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Memory
    {
        public Memory(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
