using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
{
    public enum Suite { choppen, Harten, Klaveren, Ruiten }
    public enum Getal {een, twee, drie, vier, vijf, zes, zeven, acht, negen, tien, boer, dame, koning }
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
        public override string ToString()
        {
            string totalString = $"{Getal} van {Suite}";
            return totalString;
        }
    }
}
