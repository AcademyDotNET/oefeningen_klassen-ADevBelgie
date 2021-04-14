using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schrikkeljaar\n");

            //user input
            int jaartal = Convert.ToInt32(Console.ReadLine());
            bool jaartalSchikkel = false;
            Console.Clear();

            //calc
            if((jaartal % 4) == 0)
            {
                if ((jaartal % 100) == 0)
                {
                    if ((jaartal % 400) == 0)
                    {
                        jaartalSchikkel = true;
                    }
                }
                else
                {
                    jaartalSchikkel = true;
                }
            }

            //user output
            Console.WriteLine($"{jaartal} is {(jaartalSchikkel ? null : "g" )}een schrikkeljaar");
            Console.ReadLine();
        }
    }
}
