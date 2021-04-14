using System;

namespace Grootste_getal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grootste getal\n");

            //init vars
            int x = 0;
            int y = 0;
            int grootsteGetal = 0;

            //calc
            do
            {
                y = y + x;
                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
                if ( (x > grootsteGetal) && (x != 32767) )
                {
                    grootsteGetal = x;
                }

            } while (x != 32767);

            //print
            Console.WriteLine($"Som is {y}");
            Console.WriteLine($"Grootste getal is {grootsteGetal}");
        }
    }
}
