using System;

namespace Raad_het_getal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad het getal\n");

            //init vars
            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            int onderGrens = 0;
            int bovenGrens = 10;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(onderGrens + 1, bovenGrens);

            //loop
            while (!gevonden)
            {
                aantalPogingen++;
                Console.WriteLine($"Geef een getal tussen {onderGrens} en {bovenGrens}");

                //input user
                pogingString = Console.ReadLine();
                while (!int.TryParse(pogingString, out poging) || poging >= bovenGrens || poging <= onderGrens)
                {
                    Console.WriteLine($"Geef een valide nummer tussen {onderGrens} en {bovenGrens}.");
                    pogingString = Console.ReadLine();
                }

                //calc result
                if (getal > poging)
                {
                    onderGrens = poging;
                    Console.WriteLine($"Het gezochte getal is groter, probeer opnieuw tussen {onderGrens} en {bovenGrens}.");
                }
                else if (getal < poging)
                {
                    bovenGrens = poging;
                    Console.WriteLine($"Het gezochte getal is kleiner, probeer opnieuw tussen {onderGrens} en {bovenGrens}.");
                }
                else
                    gevonden = true;
            }
            Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
        }
    }
}
