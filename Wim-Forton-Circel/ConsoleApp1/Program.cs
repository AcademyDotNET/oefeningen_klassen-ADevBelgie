using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = GeefInput();          
        }

        public static string[] GeefInput()
        {
            
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("geef uw lievelingskleur");
            string kleur = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("geef uw lievelingseten");
            string eten = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("geef uw lievelingauto");
            string auto = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("geef uw lievelingsfilm");
            string film = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("geef uw lievelingsboek");
            string boek = Console.ReadLine();

            string[] myReturnString;
            myReturnString[0] = kleur;
            myReturnString[1] = eten;
            //Console.WriteLine("Je favoriete kleur is" + eten + ". Je eet graag " + auto + ". Je lievelingsfilm is " + boek + " en je favoriete boek is " + kleur + ".");
            return myReturnString;
        }
    }
}
