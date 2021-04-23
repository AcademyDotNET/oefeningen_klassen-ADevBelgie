using System;
using System.Collections.Generic;
using System.Text;

namespace Money__money__money
{
    class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            return 0.02;
        }
    }
}
