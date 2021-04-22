using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class Patient
    {
        public string Naam { get; set; }
        public int UurInZiekehuis { get; set; }

        virtual public double BerekenKost()
        {
            int totaal = 50 + (20*UurInZiekehuis);
            return totaal;
        }

        public void ToonInfo()
        {
            Console.WriteLine("Patient info");
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Uren in het ziekenhuis: {UurInZiekehuis} uur");
            Console.WriteLine($"Totaal kosten: {BerekenKost()} uur");
        }
    }
}
