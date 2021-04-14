using System;

namespace BMI_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI berekenaar\n");

            Console.WriteLine("jouw lengte: ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("jouw gewicht: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            double bmi = (gewicht / Math.Pow(lengte, 2))*10000;
            Console.WriteLine($"jouw bmi: {Math.Round(bmi, 2)}");
        }
    }
}
