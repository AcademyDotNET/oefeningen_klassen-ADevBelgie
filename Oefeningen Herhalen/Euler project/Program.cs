using System;

namespace Euler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euler project\n");

            //init vars
            int somEuler = 0;

            //calc & print
            for(int i = 0; i <= 1000; i++)
            {
                if ( ((i%3) == 0) || ((i%5) == 0) )
                {
                    somEuler += i;
                    Console.WriteLine($"{i}");
                }
            }

            //print result
            Console.WriteLine($"\n De som is {somEuler}");
            Console.ReadLine();
        }
    }
}
