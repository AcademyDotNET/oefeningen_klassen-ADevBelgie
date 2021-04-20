using System;
using System.Collections.Generic;

namespace Student_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Organizer\n");

            List<Student> lijst= new List<Student>();
            int amountOfStudents = AmountOfStudents();
            AddStudents(lijst, amountOfStudents);

            int keuzeUser = MenuKeuze();
            while (true)
            {
                switch (keuzeUser)
                {
                    case 1:
                        EditStudent(lijst, amountOfStudents);
                        break;
                    case 2:
                        GeefOverzicht(lijst);
                        break;
                    default:
                        break;
                }
                keuzeUser = MenuKeuze();
            }
        }

        private static void EditStudent(List<Student> lijst, int amountOfStudents)
        {
            int editStudent;
            //get student to edit
            Console.WriteLine("Welke student wil je editen?");
            while (!Int32.TryParse(Console.ReadLine(), out editStudent) || !(editStudent >= 0 && editStudent <= amountOfStudents-1))
            {
                Console.WriteLine($"Geef een valide student in (0-{amountOfStudents-1})");
            }

            //get user to change said user data
            //naam
            Console.WriteLine($"Geef naam student {editStudent}");
            lijst[editStudent].Naam = Console.ReadLine();

            //leeftijd
            Console.WriteLine($"Leeftijd {lijst[editStudent].Naam}: ");
            int InputLeeftijd;
            while (!Int32.TryParse(Console.ReadLine(), out InputLeeftijd) || InputLeeftijd<1) 
            {
                Console.WriteLine($"Geef een valide leeftijd");
            }
            lijst[editStudent].Leeftijd = InputLeeftijd;

            //klas
            Console.WriteLine($"Klas {lijst[editStudent].Naam}: ");
            Klassen InputKlas;
            while (!Klassen.TryParse(Console.ReadLine().ToUpper(), out InputKlas))
            {
                Console.WriteLine($"Geef een valide klas");
            }
            lijst[editStudent].Klas = InputKlas;


            //PuntenCommunicatie
            Console.WriteLine($"Geef punten Communicatie");
            int InputPuntenCommunicatie;
            while (!Int32.TryParse(Console.ReadLine(), out InputPuntenCommunicatie) || !(InputPuntenCommunicatie >= 0 && InputPuntenCommunicatie <= 100))
            {
                Console.WriteLine($"Geef valide punten");
            }
            lijst[editStudent].PuntenCommunicatie = InputPuntenCommunicatie;

            //PuntenProgrammingPrinciples
            Console.WriteLine($"Geef punten Programming Principles");
            int InputPuntenProgrammingPrinciples;
            while (!Int32.TryParse(Console.ReadLine(), out InputPuntenProgrammingPrinciples) || !(InputPuntenProgrammingPrinciples >= 0 && InputPuntenProgrammingPrinciples <= 100))
            {
                Console.WriteLine($"Geef valide punten");
            }
            lijst[editStudent].PuntenProgrammingPrinciples = InputPuntenProgrammingPrinciples;

            //PuntenWebTech 
            Console.WriteLine($"Geef punten Web Tech ");
            int InputPuntenWebTech;
            while (!Int32.TryParse(Console.ReadLine(), out InputPuntenWebTech) || !(InputPuntenWebTech >= 0 && InputPuntenWebTech <= 100))
            {
                Console.WriteLine($"Geef valide punten");
            }
            lijst[editStudent].PuntenWebTech = InputPuntenWebTech;

            Console.WriteLine($"Press enter to continue..");
            Console.ReadLine();
            Console.Clear();
        }

        private static int AmountOfStudents()
        {
            int amountOfStudents;
            Console.WriteLine("Hoeveel studenten?");
            while (!Int32.TryParse(Console.ReadLine(), out amountOfStudents) || !(amountOfStudents >= 1 && amountOfStudents <= 20))
            {
                Console.WriteLine("Geef een valide int (1-20)");
            }
            Console.Clear();
            return amountOfStudents;
        }

        private static void AddStudents(List<Student> lijst, int studentsToAdd)
        {
            for (int i = 0; i < studentsToAdd; i++)
            {
                lijst.Add(new Student());
            }
        }

        private static void GeefOverzicht(List<Student> lijst)
        {
            foreach (var student in lijst)
            {
                student.GeefOverzicht();
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static int MenuKeuze()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Student gegevens invoeren");
            Console.WriteLine("2: Student gegevens tonen");

            int userKeuze;
            while (!Int32.TryParse(Console.ReadLine(), out userKeuze) || (userKeuze != 1 && userKeuze != 2))
            {
                Console.WriteLine("Geef een valide int (1-2)");
            }

            Console.Clear();
            return userKeuze;
        }
    }
}
