using System;

namespace Gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programma gemiddelde\n");

            Console.WriteLine("geef uw slaap in uren in september");
            int september = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef uw slaap in uren in oktober");
            int oktober = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef uw slaap in uren in november");
            int november = Convert.ToInt32(Console.ReadLine());

            double gemiddelde = (september + oktober + november) / 3.0;
            Console.WriteLine($"\nde gemiddelde slaap is {gemiddelde} uur.");
        }
    }
}
