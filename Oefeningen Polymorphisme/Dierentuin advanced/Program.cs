using System;
using System.Collections.Generic;

namespace Dierentuin_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dierentuin Advanced\n");

            ProgramDierentuin();
        }

        private static void ProgramDierentuin()
        {
            //init koe en hond
            List<DierSoort> alleDieren = new List<DierSoort>();
            alleDieren.Add(new DierSoort() { dierSoort = "Hond", dierSoortZegt = "Blaf", Gewicht = 35 });
            alleDieren.Add(new DierSoort() { dierSoort = "Koe", dierSoortZegt = "Moe", Gewicht = 400 });

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
                        DierGewichtGemiddelde(alleDieren);
                        break;
                    case 'c':
                        DierPraten(alleDieren);
                        break;
                    case 'd':
                        ToonAlleDieren(alleDieren);
                        break;
                    case 'e':
                        DierenToevoegen(alleDieren);
                        break;
                    case 'f':
                        ProgramDierentuin();
                        break;
                    default:
                        Console.WriteLine("That option is unavailable...\n");
                        break;
                }
            }
        }

        private static void DierenToevoegen(List<DierSoort> alleDieren)
        {
            //dieren toevoegen
            string keuzeDier = KeuzeDier();

            while (keuzeDier != "q")
            {
                AddDierSoort(alleDieren, keuzeDier);
                ToonAlleDieren(alleDieren);
                keuzeDier = KeuzeDier();
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

        private static void DierGewichtGemiddelde(List<DierSoort> alleDieren)
        {
            double totaalGewicht = 0;
            foreach (var dier in alleDieren)
            {
                totaalGewicht += dier.Gewicht;
            }
            Console.WriteLine($"Het gemiddelde gewicht van alle dieren is {totaalGewicht / alleDieren.Count}");

            Console.WriteLine();
        }

        private static void DierPraten(List<DierSoort> alleDieren)
        {
            if (alleDieren.Count == 0)
            {
                Console.WriteLine("Het is heel erg stil...");
            }
            else
            {
                foreach (var dier in alleDieren)
                {
                    Console.WriteLine($"{dier.dierSoortZegt}");
                }
            }

            Console.WriteLine();
        }

        private static char KeuzeMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("\ta. Dier verwijderen");
            Console.WriteLine("\tb. Diergewicht gemiddelde");
            Console.WriteLine("\tc. Dier praten");
            Console.WriteLine("\td. Toon alle dieren");
            Console.WriteLine("\te. Dieren Toevoegen");
            Console.WriteLine("\tf. Opnieuw beginnen");
            char userChar;
            while (!char.TryParse(Console.ReadLine().ToLower(), out userChar))
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
            if (alleDieren.Count == 0)
            {
                Console.WriteLine("Er zijn geen Dieren meer...");
            }
            else
            {
                foreach (var dierSoort in alleDieren)
                {
                    Console.WriteLine(dierSoort);
                }
            }

            Console.WriteLine();
        }

        private static string KeuzeDier()
        {
            Console.WriteLine("Wat voor dier moet er toegevoegd worden?(q to quit)");
            string userKeuze = Console.ReadLine();
            return userKeuze;
        }
    }
}
