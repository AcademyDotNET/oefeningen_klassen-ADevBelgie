using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class CPU
    {
        public CPU(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
