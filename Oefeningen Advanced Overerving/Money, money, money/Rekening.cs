using System;
using System.Collections.Generic;
using System.Text;

namespace Money__money__money
{
    abstract class Rekening
    {
        public Rekening()
        {
            saldo = 0;
        }
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
        }
        public bool VoegGeldToe(double geldToeTeVoegen)
        {
            saldo += geldToeTeVoegen;
            return true;
        }
        public bool HaalGeldAf(double geldAfTeHalen)
        {
            if (saldo < geldAfTeHalen)
            {
                return false;
            }
            else
            {
                saldo -= geldAfTeHalen;
                return true;
            }
        }
        public abstract double BerekenRente();
    }
}
