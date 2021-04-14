using System;

namespace Rommel_zin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit programma vraagt jou favoriete kleur, eten, auto, film en boek");
            Console.WriteLine("Kleur");
            string favorieteKleur = Console.ReadLine();
            Console.WriteLine("Eten");
            string favorieteEten = Console.ReadLine();
            Console.WriteLine("Auto");
            string favorieteAuto = Console.ReadLine();
            Console.WriteLine("Film");
            string favorieteFilm = Console.ReadLine();
            Console.WriteLine("boek");
            string favorieteBoek = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je favoriete kleur is {favorieteEten}. Je eet graag {favorieteAuto}. Je lievelingsfilm is {favorieteFilm} en je favoriete boek is {favorieteBoek}.");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Zo favoriete kleur is {favorieteFilm}?!");

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
