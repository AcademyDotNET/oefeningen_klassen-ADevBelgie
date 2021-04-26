using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
    class Kamer
    {
        public Kamer()
        {
            Oppervlakte = 10;
            Naam = "unknown";
            StandaardPrijs = 400;
        }
        public virtual int Oppervlakte { get; set; }
        
        public virtual string Naam { get; set; }
        public virtual int StandaardPrijs { get; set; }



    }
}
