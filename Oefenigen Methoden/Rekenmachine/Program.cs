using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekenmachine\n");

            //init vars
            Random rand = new Random();
            double getalA = rand.Next(1, 101);
            double getalB = rand.Next(1, 101);

            //call methodes
            Console.WriteLine($"De som van {getalA} en {getalB} is: {TelOp(getalA, getalB)}\n");
            Console.WriteLine($"De aftrekking van {getalA} en {getalB} is: {TrekAf(getalA, getalB)}\n");
            Console.WriteLine($"Het product van {getalA} en {getalB} is: {VermenigVuldig(getalA, getalB)}\n");
            Console.WriteLine($"Het quotient van {getalA} en {getalB} is: {Deel(getalA, getalB)}\n");
        }

        private static double TelOp(double getalA, double getalB)
        {
            return getalA + getalB;
        }
        private static double TrekAf(double getalA, double getalB)
        {
            return getalA - getalB;
        }
        private static double VermenigVuldig(double getalA, double getalB)
        {
            return getalA * getalB;
        }
        private static double Deel(double getalA, double getalB)
        {
            return getalA / getalB;
        }
    }
}
