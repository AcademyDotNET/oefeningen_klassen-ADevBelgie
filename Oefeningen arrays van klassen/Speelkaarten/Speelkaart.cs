using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Speelkaarten
{
    public enum Suite { choppen, Harten, Klaveren, Ruiten }
    public enum Getal {[Display(Name = "1"] een, [Display(Name = "2")] twee, [Display(Name = "3")] drie , [Display(Name = "4")] vier, [Display(Name = "5")] vijf, [Display(Name = "6")] zes, [Display(Name = "7")] zeven , [Display(Name = "8")] acht , [Display(Name = "9")] negen , [Display(Name = "10")] tien , [Display(Name = "boer")] boer , [Display(Name = "dame")] dame , [Display(Name = "koning")] koning }
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
