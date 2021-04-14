using System;

namespace KD_ratio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kill/Death-ratio\n");

            Console.WriteLine("Geef uw kills: ");
            double kills = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef uw deaths: ");
            double deaths = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nUw KD ratio is = {Math.Round(kills / deaths, 2)}.");
            
        }
    }
}
