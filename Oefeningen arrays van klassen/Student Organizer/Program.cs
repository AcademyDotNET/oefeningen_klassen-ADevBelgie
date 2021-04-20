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
            Console.WriteLine($"Geef naam student {editStudent}");
            lijst[editStudent].Naam = Console.ReadLine();

            Console.WriteLine($"Leeftijd {lijst[editStudent].Naam}: ");
            lijst[editStudent].Leeftijd = GetLeeftijd();

            Console.WriteLine($"Klas {lijst[editStudent].Naam}: ");
            lijst[editStudent].Klas = Getklas();

            Console.WriteLine($"Geef punten Communicatie");
            lijst[editStudent].PuntenCommunicatie = GetPunten();

            Console.WriteLine($"Geef punten Programming Principles");
            lijst[editStudent].PuntenProgrammingPrinciples = GetPunten();

            Console.WriteLine($"Geef punten Web Tech ");
            lijst[editStudent].PuntenWebTech = GetPunten();

            Console.WriteLine($"Press enter to continue..");
            Console.ReadLine();
            Console.Clear();
        }
        private static int GetLeeftijd()
        {
            int InputLeeftijd;
            while (!Int32.TryParse(Console.ReadLine(), out InputLeeftijd) || InputLeeftijd < 1)
            {
                Console.WriteLine($"Geef een valide leeftijd");
            }
            return InputLeeftijd;
        }
        private static Klassen Getklas()
        {
            Klassen InputKlas;
            while (!Klassen.TryParse(Console.ReadLine().ToUpper(), out InputKlas))
            {
                Console.WriteLine($"Geef een valide klas");
            }
            return InputKlas;
        }

        private static int GetPunten()
        {
            int InputPunten;
            while (!Int32.TryParse(Console.ReadLine(), out InputPunten) || !(InputPunten >= 0 && InputPunten <= 100))
            {
                Console.WriteLine($"Geef valide punten");
            }
            return InputPunten; 
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
