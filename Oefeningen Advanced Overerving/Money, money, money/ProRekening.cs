using System;
using System.Collections.Generic;
using System.Text;

namespace Money__money__money
{
    class ProRekening:SpaarRekening
    {
        public override double BerekenRente()
        {
            double totaalRente = base.BerekenRente() + ((Saldo/(int)1000) *0.01);
            return totaalRente;
        }
    }
}
