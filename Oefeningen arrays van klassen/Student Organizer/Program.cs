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
            try
            {
                while (!Int32.TryParse(Console.ReadLine(), out editStudent) || !(editStudent >= 0 && editStudent <= amountOfStudents - 1))
                {
                    Console.WriteLine($"Geef een valide student in (0-{amountOfStudents - 1})");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("selected student 0");
                editStudent = 0;
            }

            //get user to change said user data
            Console.WriteLine($"Geef naam student {editStudent}");
            try
            {
                lijst[editStudent].Naam = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                lijst[editStudent].Naam = "-1";
            }

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
            try
            {
                while (!Int32.TryParse(Console.ReadLine(), out InputLeeftijd) || InputLeeftijd < 1)
                {
                    Console.WriteLine($"Geef een valide leeftijd");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                InputLeeftijd = -1;
            }
            return InputLeeftijd;
        }
        private static Klassen Getklas()
        {
            Klassen InputKlas;
            try
            {
                while (!Klassen.TryParse(Console.ReadLine().ToUpper(), out InputKlas))
                {
                    Console.WriteLine($"Geef een valide klas");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                InputKlas = Klassen.unknown;
            }
            
            return InputKlas;
        }

        private static int GetPunten()
        {
            int InputPunten;
            try
            {
                while (!Int32.TryParse(Console.ReadLine(), out InputPunten) || !(InputPunten >= 0 && InputPunten <= 100))
                {
                    Console.WriteLine($"Geef valide punten");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                InputPunten = -1;
            }
            
            return InputPunten; 
        }

        private static int AmountOfStudents()
        {
            int amountOfStudents;
            Console.WriteLine("Hoeveel studenten?");
            try
            {
                while (!Int32.TryParse(Console.ReadLine(), out amountOfStudents) || !(amountOfStudents >= 1 && amountOfStudents <= 20))
                {
                    Console.WriteLine("Geef een valide int (1-20)");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Set amountOfStudents to 1");
                amountOfStudents = 1;
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

            int userKeuze =5;
            try
            {
                while (!Int32.TryParse(Console.ReadLine(), out userKeuze) || (userKeuze != 1 && userKeuze != 2))
                {
                    Console.WriteLine("Geef een valide int (1-2)");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                userKeuze = 3;
            }

            Console.Clear();
            return userKeuze;
        }
    }
}
