using System;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boekhouder\n");

            //init vars
            double huidigeBalans = 0;
            double somNegatief = 0;
            double somPositief = 0;
            double aantalInputs = 0;
            double inputUser;

            //loop
            while (true)
            {
                //input user
                Console.WriteLine($"\nGeef uw getal: ");
                inputUser = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                //calc
                aantalInputs++;
                huidigeBalans += inputUser;
                if (inputUser > 0)
                {
                    somPositief += inputUser;
                }
                else 
                {
                    somNegatief += inputUser;
                }

                //print
                Console.WriteLine($"Huidige Balans: {huidigeBalans}");
                Console.WriteLine($"Som negatieven: {somNegatief}");
                Console.WriteLine($"Som positieven: {somPositief}");
                Console.WriteLine($"gemiddelde: {huidigeBalans/aantalInputs}");
            }
        }
    }
}
