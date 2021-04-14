using System;

namespace Steen_schaar_papier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaar steen papier\n");

            //init vars
            string[] keuzeWorp = { "schaar", "steen", "papier" };
            Random rand = new Random();
            int worpComputer;
            int puntenUser = 0;
            int puntenComputer = 0;
            int puntenMax = 10;

            //loop spel
            do {
                //input computer
                worpComputer = rand.Next(0, 3);

                //input user
                Console.WriteLine("wat is uw keuze? ");
                string inputWorp = Console.ReadLine().ToLower();
                while (inputWorp != keuzeWorp[0] && inputWorp != keuzeWorp[1] && inputWorp != keuzeWorp[2])
                {
                    Console.WriteLine($"Geef een valide worp (schaar, steen, papier)");
                    inputWorp = Console.ReadLine();
                }

                //winnaar ronde bepalen
                if (keuzeWorp[worpComputer] != inputWorp)
                {
                    if ((worpComputer == 0 && inputWorp == "papier") || (worpComputer == 1 && inputWorp == "schaar") || (worpComputer == 2 && inputWorp == "steen"))
                    {
                        puntenComputer++;
                    }
                    else
                    {
                        puntenUser++;
                    }
                }
                else 
                {
                    Console.WriteLine($"\njullie kozen allebei voor {inputWorp}");
                }

                //print tussenstand
                Console.WriteLine($"\ntussenstand is: \nComputer = {puntenComputer}\nUser = {puntenUser}\n");

            } while ( (puntenUser < puntenMax) && (puntenComputer < puntenMax) );

            //resultaat 
            if(puntenComputer == puntenMax)
            {
                Console.WriteLine($"De winnaar is: computer");
            }
            else
            {
                Console.WriteLine($"De winnaar is: user");
            }
        }
    }
}
