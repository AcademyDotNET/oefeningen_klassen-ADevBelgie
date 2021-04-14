using System;

namespace Random_invoer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random invoer\n");
            Random somegenerator = new Random();
            double randomGetal = somegenerator.Next(0, 361);
            GeometricFun(randomGetal);
        }

        static void GeometricFun(double randomGetal)
        {
            Console.WriteLine("Geometric-fun\n");
            
            double hoekGraden = randomGetal;
            Console.WriteLine($"De hoek in graden: {hoekGraden}");

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
        }
    }
}
