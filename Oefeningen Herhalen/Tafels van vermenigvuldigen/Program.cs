using System;

namespace Tafels_van_vermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tafels van vermenigvuldigen");


            for( int i = 1; i <= 10;i++ )
            {
                Console.WriteLine($"\ntafel van {i}:");
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{i} X {y} = {i*y}");
                }
            }

            Console.ReadLine();
        }
    }
}
