using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
    class Huis
    {
        public List<Kamer> kamers = new List<Kamer>();
        
        public int BerekenPrijs()
        {
            int totaalPrijs = 0;
            foreach (var kamer in kamers)
            {
                totaalPrijs += kamer.StandaardPrijs;
            }
            return totaalPrijs;
        }
    }
}
