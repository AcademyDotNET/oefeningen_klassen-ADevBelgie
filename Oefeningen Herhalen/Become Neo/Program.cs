using System;

namespace Become_Neo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Become Neo\n");

            Random rangen = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            int randomGetal;
            //loop
            while (true)
            {
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));
                //Zet teken op scherm
                Console.Write(teken);

                //Ietwat vertragen
                System.Threading.Thread.Sleep(10); //dit getal is in milliseconden. Speel er gerust mee.

                //Af en toe donker kleurtje
                randomGetal = rangen.Next(0, 16);
                Console.ForegroundColor = (ConsoleColor)randomGetal;
            }
        }
    }
}
