using System;

namespace Enum_bij_BMI
{
    class Program
    {
        enum SoortenBMI { Ondergewicht, Normaalgewicht, Lichtovergewicht, Overgewicht, Obees }
        static void Main(string[] args)
        {
            Console.WriteLine("BMI berekenaar\n");

            //init var
            SoortenBMI userBmi;

            //user input
            Console.WriteLine("jouw lengte: ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("jouw gewicht: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            //calculate result
            double bmi = (gewicht / Math.Pow(lengte, 2)) * 10000;
            Console.Write("jouw bmi is: ");

            if (18.5 > bmi)
            {
                userBmi = SoortenBMI.Ondergewicht;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if (24.9 > bmi)
            {
                userBmi = SoortenBMI.Normaalgewicht;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if (29.9 > bmi)
            {
                userBmi = SoortenBMI.Lichtovergewicht;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else if (39.9 > bmi)
            {
                userBmi = SoortenBMI.Overgewicht;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            else
            {
                userBmi = SoortenBMI.Obees;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Math.Round(bmi, 2));
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            switch(userBmi)
            {
                case SoortenBMI.Ondergewicht:
                    Console.WriteLine("Dringend meer eten");
                    break;
                case SoortenBMI.Obees:
                    Console.WriteLine("Dringend afvallen");
                    break;
                default:
                    Console.WriteLine("Alles OK maat");
                    break;
            }
        }
    }
}
