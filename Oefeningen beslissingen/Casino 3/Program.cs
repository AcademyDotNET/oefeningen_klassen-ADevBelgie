using System;

namespace Casino_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casino\n");

            //rng & vars
            Random calcRandom = new Random();
            int randomNumber;
            int userNumber;
            int resultaat = 0; //0 = unknown, 1 = loss, 2 = win 

            //result
            for(int i = 0; (i < 3) && (resultaat != 1); i++)
            {
                //user input
                Console.WriteLine("raad het getal (1-3): ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                //rng
                randomNumber = calcRandom.Next(1, 4);

                if (userNumber != randomNumber)
                {
                    Console.WriteLine("you lose");
                    resultaat = 1;
                }
                else 
                {
                    Console.WriteLine($"poging {i + 1} correct.");
                }

                //result
                if ((i == 2) && resultaat != 1)
                {
                    Console.WriteLine("you win, you guessed 3 numbers correctly\n");
                }
            }

            Console.WriteLine("Program is over");
            Console.ReadLine();
        }
    }
}
