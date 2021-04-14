using System;

namespace Simple_math
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultInt;
            double resultDouble;
            Console.WriteLine("Oefening simple math\n");

            Console.WriteLine("-1 + 4 * 6");
            resultInt = (-1 + 4 * 6);
            Console.WriteLine($"resultaat als int {resultInt}");
            resultDouble = (-1 + 4.0 * 6);
            Console.WriteLine($"resultaat als double {resultDouble}\n");

            Console.WriteLine("( 35 + 5 ) % 7");
            resultInt = ((35 + 5) % 7);
            Console.WriteLine($"resultaat als int {resultInt}");
            resultDouble = ((35 + 5.0) % 7);
            Console.WriteLine($"resultaat als double {resultDouble}\n");

            Console.WriteLine("14 + -4 * 6 / 11");
            resultInt = (14 + -4 * 6 / 11);
            Console.WriteLine($"resultaat als int {resultInt}");
            resultDouble = (14 + -4.0 * 6 / 11);
            Console.WriteLine($"resultaat als double {resultDouble}\n");

            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2");
            resultInt = (2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine($"resultaat als int {resultInt}");
            resultDouble = (2 + 15.0 / 6 * 1 - 7 % 2);
            Console.WriteLine($"resultaat als double {resultDouble}\n");
        }
    }
}
