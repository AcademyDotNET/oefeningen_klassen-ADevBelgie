using System;
using System.Collections.Generic;
using System.Text;

namespace Money__money__money
{
    class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Saldo>100)
            {
                return 0.05;
            }
            else
            {
                return 0.00;
            }
        }
    }
}
