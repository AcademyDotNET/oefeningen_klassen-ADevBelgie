using System;

namespace Het_Orakeltje_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het Orakeltje van Delphi\n");

            Random calcRandom = new Random();
            int jarenLeven = calcRandom.Next(5,126);

            Console.WriteLine($"Je zal nog {jarenLeven} jaar leven");
            Console.ReadLine();
        }
    }
}
