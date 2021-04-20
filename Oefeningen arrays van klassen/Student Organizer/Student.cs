using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Organizer
{
    enum Klassen { EA1, EA2, EA3, EA4 }

    class Student
    {
        public Student()
        {
            //init defaults
            Naam = "defaultNaam";
            Leeftijd = 99;
            Klas = Klassen.EA1;
            PuntenCommunicatie = 0;
            PuntenProgrammingPrinciples = 0;
            PuntenWebTech = 0;
        }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public double BerekenTotaalCijfer()
        {
            return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"\n{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
        }
    }
}
