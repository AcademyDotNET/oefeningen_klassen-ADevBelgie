using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class VerzekerdePatient: Patient
    {
        double _korting = 0.9;
        override public double BerekenKost()
        {
            int totaal = 50 + (20 * UurInZiekehuis);
            return totaal*_korting;
        }
    }
}
