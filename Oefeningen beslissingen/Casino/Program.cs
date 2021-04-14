using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casino\n");

            //rng
            Random calcRandom = new Random();
            int randomNumber = calcRandom.Next(1, 7);

            //user input
            Console.WriteLine("raad het getal (1-6): ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //result
            if(userNumber == randomNumber)
            {
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("you lose");
            }

            Console.ReadLine();
        }
    }
}
