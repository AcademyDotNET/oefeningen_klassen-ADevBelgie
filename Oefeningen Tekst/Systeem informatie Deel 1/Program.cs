using System;
using static System.Environment;

namespace Systeem_informatie_Deel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine Information\n");

            Console.WriteLine($"Machine name: {Environment.MachineName}");
            Console.WriteLine($"Processor count: {Environment.ProcessorCount}");
            Console.WriteLine($"memory count: {Environment.WorkingSet}");
        }
    }
}
