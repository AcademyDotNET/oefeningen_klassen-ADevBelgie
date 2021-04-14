using System;

namespace RapportModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RapportModule\n");

            Resultaat mijnpunten = new Resultaat();
            mijnpunten.Percentage = 65;
            mijnpunten.PrintGraad();
        }
    }
}
