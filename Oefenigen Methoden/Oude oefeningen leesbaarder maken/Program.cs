using System;

namespace Oude_oefeningen_leesbaarder_maken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oude oefeningen leesbaarder maken\n");

            Console.WriteLine("Schrikkeljaar\n");

            //user input
            int jaartal = Convert.ToInt32(Console.ReadLine());
            bool jaartalSchikkel = IsSchrikkel(jaartal);
            Console.Clear();

            //user output
            Console.WriteLine($"{jaartal} is {(jaartalSchikkel ? null : "g")}een schrikkeljaar");
            Console.ReadLine();
        }

        private static bool IsSchrikkel(int jaartal)
        {
            //calc
            if ((jaartal % 4) == 0)
            {
                if ((jaartal % 100) == 0)
                {
                    if ((jaartal % 400) == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
