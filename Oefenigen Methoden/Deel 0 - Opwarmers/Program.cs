using System;

namespace Deel_0___Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deel 0 - Opwarmers\n");

            //    Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als paramater).
            double basisGetal = 10;
            double basisGetalK = Kwadraat(basisGetal);
            Console.WriteLine(basisGetalK);

            //    Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
            double diameter = 10;
            double straal = BerekenStraal(diameter);
            Console.WriteLine(diameter);

            //    Methode die het grootste van 2 getallen teruggeeft (beide getallen geef je mee als parameter).
            int getalA = 5;
            int getalB = 7;
            int grootsteGetal = BerekenGrootste(getalA, getalB);

            //    Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).
            int getalC = 7;
            bool resultEven = CheckEven(getalC);

            //    Methode IsArmstrong die bepaald of een getal een Armstrong getal is.
            int getalD = 153;
            bool isArmB = IsArmstrong(getalD);


            //    Methode ToonOEvenNummers die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.
            int getalE = 10;
            ToonOEvenNummers(getalE);

            //    Methode ToonArmstrongNummers die alle Armstrong nummers tot n toont.
            ToonArmstrongNummers(200);
        }

        private static void ToonArmstrongNummers(int getalE)
        {
            if (getalE < Math.Abs(getalE))
            {
                Console.WriteLine($"{getalE} is een negatief getal");
            }
            else
            {
                for (int i = 0; i < getalE; i++)
                {
                    Console.Write( IsArmstrong(i)? Convert.ToString(i) + " " : "" );
                }
            }
            Console.WriteLine("");
        }

        private static void ToonOEvenNummers(int getalE)
        {
            if (getalE < Math.Abs(getalE))
            {
                Console.WriteLine($"{getalE} is een negatief getal");
            }
            else 
            { 
                for(int i = 0; i < getalE; i++)
                {
                    if(i%2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            Console.WriteLine("");
        }

        private static bool IsArmstrong(int getalD)
        {
            //init vars
            string getalDS = Convert.ToString(getalD);
            int lengteGetal = getalDS.Length;
            double tempTotaal = 0;

            //calc
            for (int i = 0; i < lengteGetal; i++)
            {
                int tempGetal = Convert.ToInt32(getalDS[i]) - 48;
                tempTotaal += Math.Pow((double)tempGetal, lengteGetal);
            }

            //return with value
            if (getalD == (int)tempTotaal)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private static bool CheckEven(int getalC)
        {
            if (getalC%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int BerekenGrootste(int getalA, int getalB)
        {
            if(getalA > getalB)
            {
                return getalA;
            }
            else
            {
                return getalB;
            }
        }

        private static double BerekenStraal(double diameter)
        {
            return diameter / 2;
        }

        private static double Kwadraat(double basisGetal)
        {
            return basisGetal * basisGetal;
        }
    }
}

//Een extra grote hoop oefeningen om je methoden te drillen (originele bron). De oefeningen zijn ongeveer gerangschikt naar moeilijkheid.

//Iedere oefening verwacht dat je steeds een methode schrijft en de werking ervan aantoont:

//    Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als paramater).
//    Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
//    Idem voor omtrek en oppervlakte.
//    Methode die het grootste van 2 getallen teruggeeft (beide getallen geef je mee als parameter).
//    Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).
//    Methode IsArmstrong die bepaald of een getal een Armstrong getal is.
//    Methode ToonOEvenNummers die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.
//    Methode ToonArmstrongNummers die alle Armstrong nummers tot n toont.
