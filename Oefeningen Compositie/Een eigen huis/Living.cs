using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
    class Living : Kamer
    {
        public Living(bool _schouw = false)
        {
            Schouw = _schouw;
            StandaardPrijs = 300;
            if (Schouw)
            {
                StandaardPrijs += 200;
            }
        }
        public bool Schouw { get; set; }
    }
}
