using System;

namespace Op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Op-de-poef\n");

            double poef = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nvoer bedrag in?");
                poef += Convert.ToDouble(Console.ReadLine());
            }

            int aantalWeken = Convert.ToInt32(Math.Round( ( poef / 10 ), 0, MidpointRounding.ToPositiveInfinity));

            Console.WriteLine("*************************");
            Console.WriteLine($"Het totaal van  de poef is {poef} en zal {aantalWeken} week(en) duren om volledig afbetaald te worden.");
        }
    }
}
