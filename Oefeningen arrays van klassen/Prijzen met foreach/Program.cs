using System;

namespace Prijzen_met_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijzen met foreach\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int sizeArray = 20;
            double[] prijzen = FillArray(sizeArray);
            double average = 0;

            //print prijzen hoger dan 5 Euro
            foreach (var prijs in prijzen)
            {
                average += prijs;
                if (prijs>=5)
                {
                    Console.WriteLine($"{prijs:C}");
                }
            }

            //Toon op het einde van het programma het gemiddelde van alle prijzen (dus inclusief de lagere prijzen).
            Console.WriteLine($"Het gemiddelde van alle prijzen is: {average/sizeArray}");
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
