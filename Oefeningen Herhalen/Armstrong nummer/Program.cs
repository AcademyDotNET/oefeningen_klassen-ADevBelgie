using System;
using static System.Math;

namespace Armstrong_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[PRO] Armstrong nummer\n");

            //init vars
            double lengteGetal;
            int userGetalI;
            double tempTotaal = 0;

            //input user
            string userGetalS = Console.ReadLine();

            //calc
            lengteGetal = userGetalS.Length;
            userGetalI = Convert.ToInt32(userGetalS);

            for (int i = 0; i < lengteGetal; i++)
            {
                int tempGetal = Convert.ToInt32(userGetalS[i]) - 48;
                tempTotaal += Math.Pow((double)tempGetal, lengteGetal);
            }

            //print
            Console.WriteLine($"De som is: {tempTotaal}");
            if (userGetalI == (int)tempTotaal)
            {
                Console.WriteLine($"het getal {userGetalS} is dus een Armstrong nummer");
            }
            else
            {
                Console.WriteLine($"het getal {userGetalS} is dus geen Armstrong nummer");

            }

            Console.ReadLine();
        }
    }
}
