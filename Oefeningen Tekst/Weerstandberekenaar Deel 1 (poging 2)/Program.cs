using System;

namespace Weerstandberekenaar_Deel_1__poging_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue" };

            Console.WriteLine("geef waarde ring 1 tussen 0-9:");
            int ring1 = Convert.ToInt32(Console.ReadLine());
            while( ring1 < 0 || ring1 > 9 )
            {
                Console.WriteLine("dat is geen valide getal, geef een getal tussen 0-9: ");
                ring1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"de eerste ring is {colors[ring1]}");

            Console.WriteLine("geef waarde ring 2");
            int ring2 = Convert.ToInt32(Console.ReadLine());
            while (ring2 < 0 || ring2 > 9)
            {
                Console.WriteLine("dat is geen valide getal, geef een getal tussen 0-9: ");
                ring2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"de tweede ring is {colors[ring2]}");

            Console.ForegroundColor = (ConsoleColor)ring1;
            Console.Write($"{ring1}");
            Console.ForegroundColor = (ConsoleColor)ring2;
            Console.Write($"{ring2}\n\n");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
