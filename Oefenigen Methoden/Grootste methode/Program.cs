using System;

namespace Grootste_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grootste methode\n");

            //init vars
            Random rand = new Random();
            int getalA = rand.Next(1, 101);
            int getalB = rand.Next(1, 101);
            int getalC = rand.Next(1, 101);

            //calc biggest
            int grootste = BerekenGrootste(getalA, getalB, getalC);

            //print result
            Console.WriteLine($"getal A: {getalA}\ngetal B: {getalB}\ngetal C: {getalC}\n");
            Console.WriteLine($"\nGrootste getal: {grootste}");
        }

        private static int BerekenGrootste(int getalA, int getalB, int getalC)
        {
            if (getalA>getalB && getalA > getalC)
            {
                return getalA;
            }
            else if (getalB > getalA && getalB > getalC)
            {
                return getalB;
            }
            else
            {
                return getalC;
            }
        }
    }
}
