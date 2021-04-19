using System;
using System.Collections.Generic;
using System.Text;

namespace Digitale_kluis
{
    class DigitaleKluis
    {
        private int _code;
        public DigitaleKluis()
        {

        }
        public DigitaleKluis(int code)
        {
            _code = code;
        }

        private bool _canShowCode = false;

        public bool CanShowCode
        {
            get { return _canShowCode; }
            set { _canShowCode = value; }
        }
        private int _codeLevel;

        public int CodeLevel
        {
            get 
            {
                _codeLevel = _code / 1000;
                return _codeLevel; 
            }
        }

        public int Code
        {
            get 
            {
                if (_canShowCode)
                {
                    return _code;
                }
                else
                {
                    return -666;
                }
                 
            }
            private set { _code = value; }
        }

        private int aantalpogingen = 0;
        public bool TryCode(int userTry)
        {
            if (userTry == _code)
            {
                Console.WriteLine("U heeft correct geraden!");
                Console.WriteLine($"U heeft {aantalpogingen} keer fout geraden");
                return true;
            }
            else
            {
                if (userTry == -666)
                {
                    Console.WriteLine("U bent een valsspeler");
                }
                Console.WriteLine("U heeft niet correct geraden.");
                aantalpogingen++;
                return false;
            }
        }
    }
}
