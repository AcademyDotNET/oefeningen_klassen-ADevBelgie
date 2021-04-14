using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Ik ben {MijnEersteMethode()}");
            Console.WriteLine("goedendag " + UserInput() + " alles goed?"); 
        }

        public static string MijnEersteMethode()
        {
            return "Arthur Devresse";
        }

        public static string UserInput()
        {
            Console.WriteLine("Geef uw naam");
            string name = Console.ReadLine();
            return name;
        }
    }
}
