using System;

namespace Supercomputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supercomputer");
            Console.WriteLine("Geef 3 komma getallen:");
            double getal1 = ReadNumber((int)1);
            double getal2 = ReadNumber((int)2);
            double getal3 = ReadNumber((int)3);
            Console.WriteLine($"Het gemiddelde is: {(getal1 + getal2 + getal3) / 3}");
            Console.ReadLine();
        }

        static double ReadNumber(int number) 
        {
            Console.WriteLine($"Geef getal {number}: ");
            double returnNumber = Convert.ToDouble(Console.ReadLine());
            return returnNumber;
        }
    }
}
