using System;

namespace Galgje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("galgje\n");

            string woordTeRaden = User1Init();

            SpelGalgje(woordTeRaden);

            Console.ReadLine();
        }

        private static void SpelGalgje(string woordTeRaden)
        {
            int pogingenOmTeWinnen = 7;
            char userChar;
            char[] woordTeRadenArray = woordTeRaden.ToCharArray(); // word user 1 gave in char array
            char[] woordGeradenArray = initWoordGeradenArray(woordTeRadenArray); // looks like ------
            //string woordGeraden;



            for (int i = 0; i < pogingenOmTeWinnen; i++)
            {
                Console.Write($"woord:");
                for (int k = 0; k < woordGeradenArray.Length; k++)
                {
                    Console.Write(woordGeradenArray[k]);
                }

                Console.WriteLine("\nraad een getal: ");
                userChar = GetUserChar();

                for (int y = 0; y < woordTeRadenArray.Length; y++)
                {
                    if (woordTeRadenArray[y] == userChar)
                    {
                        woordGeradenArray[y] = woordTeRadenArray[y];
                        
                    }
                }

                string woordGeraden = new string(woordGeradenArray);
                if (woordGeraden == woordTeRaden)
                {
                    Console.WriteLine("user 2 wint!! ");
                    return;
                }
            }

            Console.WriteLine("user 1 wint!! ");
            return;
        }

        private static char[] initWoordGeradenArray(char[] woordTeRadenArray)
        {
            char[] woordGeradenArray = new char[woordTeRadenArray.Length];

            for (int i = 0; i < woordTeRadenArray.Length; i++)
            {
                woordGeradenArray[i] = '-';
            }

            return woordGeradenArray;
        }

        private static string User1Init()
        {
            Console.WriteLine("user 1 geef het woord dat de andere user moet raden: ");
            string woordTeRaden = Console.ReadLine();

            Console.Clear();
            return woordTeRaden.ToUpper();
        }

        private static char GetUserChar()
        {
            char userChar;

            Console.WriteLine("geef character (A-Z):");
            string tempRatingS = Console.ReadLine().ToUpper();

            while (!char.TryParse(tempRatingS, out userChar) || userChar < 65 || userChar > 90)
            {
                Console.WriteLine("geef valide character (A-Z):");
                tempRatingS = Console.ReadLine().ToUpper();
            }

            return userChar;
        }
    }
}
