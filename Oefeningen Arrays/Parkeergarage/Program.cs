using System;

namespace Parkeergarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parkeergarage\n");

            //Veronderstel dat er nooit langer dan 1 dag (24u) kan geparkeerd worden.
            //init vars
            double prijsDrieUur = 2;
            double prijsPerUur = 0.5;
            double maxPerDag = 10;

            //user input
            Console.WriteLine("Hoeveel auto's?");
            int aantalAutos = Convert.ToInt32(Console.ReadLine());
            int[] duurParkeren = DuurParkerenPerAuto(aantalAutos);

            berekenKosten(0, duurParkeren, prijsDrieUur, prijsPerUur, maxPerDag);

            //print result
            printResult(duurParkeren, prijsDrieUur, prijsPerUur, maxPerDag);
        }

        private static double berekenKosten(int welkeAuto, int[] duurParkeren, double prijsDrieUur = 2, double prijsPerUur = 0.5, double maxPerDag = 10)
        {
            double kosten;

            if(duurParkeren[welkeAuto] > 3)
            {
                kosten = prijsDrieUur;
                kosten += (duurParkeren[welkeAuto] - 3) * prijsPerUur;
            }
            else
            {
                kosten = prijsDrieUur;
            }

            kosten = Math.Min(10.0, kosten);

            return kosten;
        }

        private static int[] DuurParkerenPerAuto(int aantalAutos)
        {
            int[] duurParkeren = new int[aantalAutos];

            //loop
            for (int i = 0; i < aantalAutos; i++)
            {
                //user input
                Console.WriteLine($"Geef parkeertijd auto {i+1} in (uren):");
                duurParkeren[i] = Convert.ToInt32(Console.ReadLine());
            }

            return duurParkeren;
        }

        private static void printResult(int[] duurParkeren, double prijsDrieUur = 2, double prijsPerUur = 0.5, double maxPerDag = 10)
        {
            //init vars
            double somKosten = 0;
            double tempKosten;
            int somDuur = 0;


            //user output
            Console.WriteLine("\nAuto\tDuur\tKost");

            for (int i = 0; i < duurParkeren.Length; i++)
            {
                somDuur += duurParkeren[i];
                tempKosten = berekenKosten(i, duurParkeren);
                somKosten += tempKosten;
                Console.WriteLine($"{i + 1}\t{duurParkeren[i]}\t{tempKosten}");
            }
            Console.WriteLine($"{duurParkeren.Length}\t{somDuur}\t{somKosten}");
        }
    }
}



//Een parkeergarage vraagt sowieso €2.00 om tot maximum 3uur te parkeren. Per extra uur NA die 3uur wordt telkens €0.50 aangerekend (dus 4uur parkeren kost €2.50. Er wordt maximum €10 aangerekend per dag. Veronderstel dat er nooit langer dan 1 dag (24u) kan geparkeerd worden.

//Schrijf een programma dat het verschuldigde bedrag toont gegeven de duur dat de parkeergarage gebruikt werd. Bij het opstarten van het programma wordt eerst gevraagd hoeveel auto’s ingevoerd zullen worden, dan wordt per auto de duur van het parkeren gevraagd. Finaal wordt, netjes getabuleerd, alle informatie getoond, inclusief het totaal bedrag. Gebruik minstens 1 methode ‘berekenKosten’ die de kost voor 1 gebruiker telkens teruggeeft, gegeven de duur als parameter. Gebruik ook een methode die een array als parameter aanvaard (bijvoorbeeld de array met daarin de respectievelijke uren per auto).

//Voorbeeldoutput: Opstart:

//Geef aantal auto 's in: 


//Geef parkeertijd auto 1 in (uren):
//Geef parkeertijd auto 2 in (uren):
//etc..Resultaat:

//Auto Duur    Kost
//1    x    y
//2    x    y
//..
//2(=totaal aantal auto's)    som(x)    som(y)