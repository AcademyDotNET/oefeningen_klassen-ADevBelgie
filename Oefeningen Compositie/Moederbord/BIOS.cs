using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class BIOS
    {
        public BIOS(string version)
        {
            Version = version;
        }
        public string Version { get; private set; }
    }
}
