using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Reptile: Animal
    {
        public Reptile():base()
        {
            Limbs = true;
        }
        public bool Limbs { get; set; }

        override public void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Limbs: {Limbs}");
        }
    }
}
