using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schoenverkoper\n");

            //init vars
            int kortingVanaf = 9;
            double prijsNormaal = 20;
            double prijsKorting = 10;
            double prijsTeBetalen = 0;    

            //get user input
            Console.WriteLine("Hoeveel paar schoenen wil jij verkopen?");
            int aantalKopen = Convert.ToInt32(Console.ReadLine());

            //get user input 
            Console.WriteLine("Vanaf hoeveel paar is er korting?");
            kortingVanaf = Convert.ToInt32(Console.ReadLine());

            //calculate total price
            if (aantalKopen <= kortingVanaf) 
            {
                prijsTeBetalen = prijsNormaal * aantalKopen;
            }
            else
            {
                prijsTeBetalen = prijsNormaal * kortingVanaf;
                prijsTeBetalen += prijsKorting * (aantalKopen - kortingVanaf);
            }

            //print price
            Console.WriteLine($"\ntotaalprijs = {prijsTeBetalen}");
            Console.WriteLine($"Bij de eerste {kortingVanaf} geldde er geen korting.({kortingVanaf} * {prijsNormaal} + {(aantalKopen - kortingVanaf)} * {prijsKorting})");
            Console.ReadLine();
        }
    }
}
