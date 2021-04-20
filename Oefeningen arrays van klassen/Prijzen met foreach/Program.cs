using System;

namespace Prijzen_met_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijzen met foreach\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double[] prijzen = FillArray(20);

            foreach (var prijs in prijzen)
            {
                if (prijs>=5)
                {
                    Console.WriteLine($"{prijs:C}");
                }
            }
        }

        private static double[] FillArray(int size)
        {
            double[] array = new double[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 20);
            }
            return array;
        }
    }
}
