using System;

namespace Sport_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sportspeler\n");

            SpelerBox zwakke = new SpelerBox();
            zwakke.Naam = "zwakke";
            zwakke.RunMarathon();
            zwakke.ShowOffStrength();
            Console.WriteLine();

            SpelerBox sterke = new SpelerBox();
            sterke.Naam = "sterke";
            sterke.StelIn();
            sterke.RunMarathon();
            sterke.ShowOffStrength();
        }
    }
}
