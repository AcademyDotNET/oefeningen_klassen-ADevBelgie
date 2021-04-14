using System;
using System.Collections.Generic;
using System.Text;

namespace RapportModule
{
    class Resultaat
    {
        public int Percentage{ get; set; }

        public Resultaat()
        {

        }

        public void PrintGraad()
        {
            if (Percentage < 50)
            {
                Console.WriteLine($"< 50: niet geslaagd {Percentage}");
            }
            else if (Percentage < 68)
            {
                Console.WriteLine($"tussen 50 en 68: voldoende; {Percentage}");
            }
            else if (Percentage < 75)
            {
                Console.WriteLine($"tussen 68 en 75: onderscheiding; {Percentage}");
            }
            else if (Percentage < 85)
            {
                Console.WriteLine($"tussen 68 en 75: onderscheiding; {Percentage}");
            }
            else
            {
                Console.WriteLine($"> 85: grootste onderscheiding. {Percentage}");
            }

            return;
        }
    }
}
