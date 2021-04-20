using System;
using System.Collections.Generic;
using System.Text;

namespace Speelkaarten
{
    public enum Suite { choppen, Harten, Klaveren, Ruiten }
    public enum Getal { een, twee, drie ,vier, vijf, zes, zeven ,acht ,negen ,tien ,boer ,dame ,koning }
    class Speelkaart
    {
        private Getal _Getal;

        public Getal Getal
        {
            get { return _Getal; }
            set { _Getal = value; }
        }
        private Suite _Suite;

        public Suite Suite
        {
            get { return _Suite; }
            set { _Suite = value; }
        }

    }
}
