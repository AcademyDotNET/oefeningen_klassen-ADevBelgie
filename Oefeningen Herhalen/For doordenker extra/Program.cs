using System;

namespace For_doordenker_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[PRO] For doordenker extra\n");

            //user input
            Console.WriteLine("Geef een nummer");
            int userGetal = Convert.ToInt32(Console.ReadLine());

            //print output
            Console.WriteLine("");
            for (int i = 0; i < userGetal; i++)
            {
                for (int y = i; y < userGetal; y++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < (((i + 1)*2)-1); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
