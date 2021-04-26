using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class President: Minister
    {
        public President()
        {
            teller = 4;
        }
        private int teller;

        public int Teller
        {
            get { return teller; }
            private set { teller = value; }
        }

        public void JaarVerder()
        {
            teller--;
        }
    }
}
