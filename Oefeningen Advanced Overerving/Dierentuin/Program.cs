using System;
using System.Collections.Generic;

namespace Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dierentuin\n");

            ProgramDierentuin();
        }

        private static void ProgramDierentuin()
        {
            //init koe en hond
            List<DierSoort> alleDieren = new List<DierSoort>();
            alleDieren.Add(new DierSoort() { dierSoort = "Hond", dierSoortZegt = "Blaf", Gewicht = 35 });
            alleDieren.Add(new DierSoort() { dierSoort = "Koe", dierSoortZegt = "Moe", Gewicht = 400 });

            ToonAlleDieren(alleDieren);

            //dieren toevoegen
            string keuzeDier = KeuzeDier();

            while (keuzeDier != "q")
            {
                AddDierSoort(alleDieren, keuzeDier);
                ToonAlleDieren(alleDieren);
                keuzeDier = KeuzeDier();
            }

            Console.Clear();

            //Keuze menu

            while (true)
            {
                char keuzeMenu = KeuzeMenu();
                Console.Clear();
                switch (keuzeMenu)
                {
                    case 'a':
                        RemoveDierVanList(alleDieren);
                        break;
                    case 'b':
                        DiergewichtGemiddelde(alleDieren);
                        break;
                    case 'c':
                        DierPraten(alleDieren);
                        break;
                    case 'd':
                        ProgramDierentuin();
                        break;
                    default:
                        Console.WriteLine("That option is unavailable...\n");
                        break;
                }
            }
        }

        private static void RemoveDierVanList(List<DierSoort> alleDieren)
        {
            ToonAlleDieren(alleDieren);

            Console.WriteLine("Geef de index van het dier dat u uit de luist wilt verwijderen");
            alleDieren.RemoveAt(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();
            ToonAlleDieren(alleDieren);
            Console.WriteLine();
        }

        private static void DiergewichtGemiddelde(List<DierSoort> alleDieren)
        {
            double totaalGewicht = 0;
            foreach (var dier in alleDieren)
            {
                totaalGewicht += dier.Gewicht;
            }
            Console.WriteLine($"Het gemiddelde gewicht van alle dieren is {totaalGewicht/ alleDieren.Count}");

            Console.WriteLine();
        }

        private static void DierPraten(List<DierSoort> alleDieren)
        {
            foreach (var dier in alleDieren)
            {
                Console.WriteLine($"{dier.dierSoortZegt}");
            }
            Console.WriteLine();
        }

        private static char KeuzeMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("a. Dier verwijderen");
            Console.WriteLine("b. Diergewicht gemiddelde");
            Console.WriteLine("c. Dier praten");
            Console.WriteLine("d. Opnieuw beginnen");
            char userChar;
            while (!char.TryParse(Console.ReadLine(), out userChar)) 
            {
                Console.WriteLine("Geef een valide char");
            }
            return Char.ToLower(userChar);
        }

        private static void AddDierSoort(List<DierSoort> alleDieren, string dierSoort)
        {
            Console.WriteLine($"Wat zegt de {dierSoort}?");
            string dierSoortZegt = Console.ReadLine();
            Console.WriteLine($"Wat is het gewicht van de {dierSoort}?");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            alleDieren.Add(new DierSoort() { dierSoort = dierSoort, dierSoortZegt = dierSoortZegt, Gewicht = gewicht });
        }

        private static void ToonAlleDieren(List<DierSoort> alleDieren)
        {
            Console.WriteLine("Dierentuin\n");

            foreach (var dierSoort in alleDieren)
            {
                Console.WriteLine(dierSoort);
            }
            Console.WriteLine();
        }

        private static string KeuzeDier()
        {
            Console.WriteLine("Wat voor dier moet er toegevoegd worden?");
            string userKeuze = Console.ReadLine();
            return userKeuze;
        }
    }
}
