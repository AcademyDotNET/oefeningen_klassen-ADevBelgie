using System;

namespace Ohm_berekenaar
{
    class Program
    {
        enum electriciteit { spanning = 'U', weerstand = 'R', stroomsterkte = 'I' }
        static void Main(string[] args)
        {
            Console.WriteLine("Ohm-berekenaar\n");

            //init vars
            double ohm;
            double ampere;
            double volt;

            //get user input
            Console.WriteLine("Welke onbekende wil je bereken in de wet can Ohm?(U, R, I)");
            electriciteit userKeuzeOnbekende = (electriciteit)Convert.ToChar(Console.ReadLine());


            //calculate with user input
            switch (userKeuzeOnbekende)
            {
                case (electriciteit)'U':
                    Console.WriteLine("Geef de weerstand in Ohm: ");
                    ohm = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geef de stroomsterkte in Ampère: ");
                    ampere = Convert.ToDouble(Console.ReadLine());
                    volt = ohm * ampere;
                    Console.WriteLine($"De spanning in Volt is:{volt}");
                    break;
                case (electriciteit)'R':
                    Console.WriteLine("Geef de stroomsterkte in Ampère: ");
                    ampere = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geef de spanning in Volt: ");
                    volt = Convert.ToDouble(Console.ReadLine());
                    ohm = volt / ampere;
                    Console.WriteLine($"De weerstand in Ohm is:{ohm}");
                    break;
                case (electriciteit)'I':
                    Console.WriteLine("Geef de weerstand in Ohm: ");
                    ohm = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geef de spanning in Volt: ");
                    volt = Convert.ToDouble(Console.ReadLine());
                    ampere = volt / ohm;
                    Console.WriteLine($"De stroom in Ampère is:{ampere}");
                    break;
                default:
                    Console.WriteLine("There was an error");
                    break;
            }

        }
    }
}
