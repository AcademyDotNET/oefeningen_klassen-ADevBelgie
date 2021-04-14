using System;

namespace Auto_oef_klasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto_oef_klasses\n");

            Auto autoArthur = new Auto();

            autoArthur.GeefKilometersWeer();
            autoArthur.RijKilometer();
            autoArthur.RijKilometer();
        }
    }
}
