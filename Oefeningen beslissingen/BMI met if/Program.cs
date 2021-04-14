using System;

namespace BMI_met_if
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

            double bmi = (gewicht / Math.Pow(lengte, 2)) * 10000;
            Console.Write("jouw bmi is: ");

            if (18.5 > bmi) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if(24.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if (29.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if (39.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
