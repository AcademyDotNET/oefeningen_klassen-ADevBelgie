using System;

namespace For_doordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[PRO] For doordenker\n");

            //user input
            Console.WriteLine("Geef een nummer");
            int userGetal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //print output
            for (int i = 0; i < userGetal; i++)
            {
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = userGetal; i > 0; i--)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
