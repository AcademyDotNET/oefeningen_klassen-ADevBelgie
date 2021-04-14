using System;

namespace Tafel_en_Console.Clear__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tafel en Console.Clear()\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} X 411 = {i * 411}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
