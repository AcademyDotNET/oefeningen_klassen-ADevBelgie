using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric-fun\n");

            Console.WriteLine("Geef een hoek in graden: ");
            double hoekGraden = Convert.ToDouble(Console.ReadLine());

            //bereken hoek informatie
            double hoekRadialen = Math.PI * (hoekGraden / 180.0);
            double hoekSinus = Math.Sin(hoekRadialen);
            double hoekCosinus = Math.Cos(hoekRadialen);
            double hoekTangens = Math.Tan(hoekRadialen);

            //print hoek informatie
            Console.WriteLine("\nInformatie over de hoek:");
            Console.WriteLine($"Radialen: {Math.Round(hoekRadialen, 4)}");
            Console.WriteLine($"Sinus: {Math.Round(hoekSinus, 4)}");
            Console.WriteLine($"Cosinus: {Math.Round(hoekCosinus, 4)}");
            Console.WriteLine($"Tangens: {Math.Round(hoekTangens, 4)}");

            Console.ReadLine();
        }
    }
}
