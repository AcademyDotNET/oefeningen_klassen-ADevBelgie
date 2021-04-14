using System;

namespace Orakeltje_van_Delphi__part_deux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het Orakeltje van Delphi\n");

            //init rng & vars
            Random calcRandom = new Random();
            int jarenLeven;

            //user input
            Console.WriteLine("ben je een man(m) of een vrouw(v)?");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nwat is uw leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());

            //RNG & print console
            switch (gender)
            {
                case 'm':
                    jarenLeven = calcRandom.Next(leeftijd, 121);
                    Console.WriteLine($"Je zal nog {jarenLeven - leeftijd} jaar leven");
                    break;
                case 'v':
                    jarenLeven = calcRandom.Next(leeftijd, 151);
                    Console.WriteLine($"Je zal nog {jarenLeven - leeftijd} jaar leven");
                    break;
                default:
                    Console.WriteLine("je hebt een foute letter ingegeven.");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
