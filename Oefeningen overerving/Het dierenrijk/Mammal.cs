using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Mammal: Animal
    {
        public Mammal():base()//:base() doesn't change anything to this line
        {
            LandMammal = true;
        }
        public bool LandMammal { get; set; }

        override public void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"LandMammal: {LandMammal}");
        }
    }
}
