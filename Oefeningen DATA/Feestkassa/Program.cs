using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feestkassa\n");

            string[] itemsTeKoop = { "Frietjes", "koninginnehapje", "ijsje", "dranken" };
            int[] prijsItemsTeKoop = { 20, 10, 3, 2 };
            double totaalPrijs = 0;
            double tussenPrijs = 0;
            int i = 0;

            foreach (string item in itemsTeKoop)
            {
                Console.WriteLine($"{item}?");
                tussenPrijs = prijsItemsTeKoop[i] * Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"tussenprijs = {totaalPrijs} + {tussenPrijs}");
                totaalPrijs += tussenPrijs;
                i++;
            }

            Console.WriteLine($"\nHet totaal te betalen gedrag is {totaalPrijs} Euro.");
            Console.ReadLine();
        }
    }
}
