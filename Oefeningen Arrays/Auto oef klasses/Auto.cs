using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_oef_klasses
{
    class Auto
    {
        private int aantalKilometers = 0;
        private int huidigeSnelheid = 0;
        private int wielenV;
        private int gewichtV;
        private int maxSnelheidV;
        
        public Auto(int wielen = 4, int gewicht = 2000, int maxSnelheid = 200)
            {
                wielenV = wielen;
                gewichtV = gewicht;
                maxSnelheidV = maxSnelheid;
            }
        
        public void RijKilometer()
            {
                aantalKilometers++;
                GeefKilometersWeer();
            }
        
        public void GeefKilometersWeer()
            {
                Console.WriteLine($"De huidige kilometerstand is: {aantalKilometers} km.");
            }
    }
}
