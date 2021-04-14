using System;
using System.Collections.Generic;
using System.Text;

namespace Studentklasse
{
    public enum Klassen { EA2, A1, A2, A3 }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public double BerekenTotaalCijfer()
        {
            double gemiddeld = (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech)/3.0;
            return gemiddeld;
        }
        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}");

            Console.WriteLine("\nCijferrapport: \n**********");
            Console.WriteLine($"Communicatie: {PuntenCommunicatie}");
            Console.WriteLine($"Web Technology: {PuntenWebTech}");
            Console.WriteLine($"Programming Principles: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Gemiddelde: {BerekenTotaalCijfer():F1}");
            return;
        }
    }
}
