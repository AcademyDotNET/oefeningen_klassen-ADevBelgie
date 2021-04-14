using System;

namespace Gewicht_in_space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gewicht in space\n");

            double gewichtOpAarde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nJe weegt op Mercurius {gewichtOpAarde * 0.38} kg.");
            Console.WriteLine($"\nJe weegt op Venus {gewichtOpAarde * 0.91} kg.");
            Console.WriteLine($"\nJe weegt op Aarde {gewichtOpAarde * 1.00} kg.");
            Console.WriteLine($"\nJe weegt op Mars {gewichtOpAarde * 0.38} kg.");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nJe weegt op Jupiter {gewichtOpAarde * 2.34} kg.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"\nJe weegt op Saturnus {gewichtOpAarde * 1.06} kg.");
            Console.WriteLine($"\nJe weegt op Uranus {gewichtOpAarde * 0.92} kg.");
            Console.WriteLine($"\nJe weegt op Neptunus {gewichtOpAarde * 1.19} kg.");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nJe weegt op Pluto {gewichtOpAarde * 0.06} kg.");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
