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
            double totaal = base.BerekenKost();
            return totaal*_korting;
        }
    }
}
