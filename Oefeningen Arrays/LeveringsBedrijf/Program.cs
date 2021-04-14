using System;

namespace LeveringsBedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LeveringsBedrijf\n");

            //init var
            int[] postcodeGemeente = { 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010 };
            int[] prijsPerKG = VulArray(postcodeGemeente.Length);
            double prijsTeBetalen;

            //input user
            Console.WriteLine("geef gewicht packet");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("naar welke gemeente?");
            int gemeente = Convert.ToInt32(Console.ReadLine());

            //process
            prijsTeBetalen = gewicht * prijsPerKG[BepaalGemeente(gemeente, postcodeGemeente)];

            //result
            Console.WriteLine($"om {gewicht}kg naar gemeente {gemeente} te sturen kost dat {prijsTeBetalen} (prijs per kilo: {prijsTeBetalen/ gewicht})");
        }

        private static int BepaalGemeente(int gemeente, int[] postcodeGemeente)
        {
            //loop
            while (true)
            {
                for (int i = 0; i < postcodeGemeente.Length; i++)
                {
                    if (gemeente == postcodeGemeente[i])
                    {
                        return i;
                    }
                }
                Console.WriteLine("Geef een valide gemeente");
                gemeente = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int[] VulArray(int arraySize)
        {
            //declare vars
            int[] arrayToFill = new int[arraySize];
            Random rand = new Random();

            //init array
            for (int i = 0; i < arraySize; i++)
            {
                arrayToFill[i] = rand.Next(0, 10);
            }

            return arrayToFill;
        }
    }
}



//Maak een programma voor een koeriersbedrijf. Maak een array die 10 postcodes bevat (zelf te kiezen)
//van gemeenten waar het bedrijf naar levert. Maak een tweede array die de prijs bevat per kg van iedere respectievelijke gemeente.
//Het eerste element van deze array bevat dus de prijs/kg om naar de gemeente die als eerste in de array met postcodes staat.

//Vraag aan de gebruiker een postcode en het gewicht van het pakket. Vervolgens wordt de prijs opgezocht voor die gemeente en wordt deze berekend gegeven het ingegeven gewicht.

//Indien het bedrijf niet levert aan de ingetypte postcode dan wordt een foutmelding weergegeven.

//Geef gewicht pakket
//45
//Naar welke postcode wenst u dit pakket te versturen?
//2020
//Dit zal 9630 euro kosten.

