using System;

namespace ArrayOefener_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayOefener 1\n");

            //init vars
            int sizeArray = 10;
            int[] arrayVanTien = InitArray(sizeArray: sizeArray);
            int somArrayVanTien = CalcArraySom(arrayVanTien);
            double gemiddeldeArrayVanTien = somArrayVanTien / (double)sizeArray;
            int grootsteArrayVanTien = CalcGrootsteArray(arrayVanTien);

            //output console
            Console.WriteLine($"Som: {somArrayVanTien}");
            Console.WriteLine($"Gemiddelde: {gemiddeldeArrayVanTien}");
            Console.WriteLine($"Grootste: {grootsteArrayVanTien}");

            //input user
            Console.WriteLine("\ninput user:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            CompareToArray(userInput, arrayVanTien);
        }

        private static void CompareToArray(int userInput, int[] arrayVanTien)
        {
            bool inputSmallest = true;
            for (int i = 0; i < arrayVanTien.Length; i++)
            {
                if (arrayVanTien[i] >= userInput)
                {
                    Console.Write($"{arrayVanTien[i]} ");
                }
            }
            if (inputSmallest)
            {
                Console.WriteLine($"\nhet door de user ingegeven {userInput} is het grootste getal");
            }
            else
            {
                Console.WriteLine("");
            }
        }

        private static int CalcGrootsteArray(int[] arrayVanTien)
        {
            int grootste = 0;

            for (int i = 0; i < arrayVanTien.Length; i++)
            {
                if(arrayVanTien[i] > grootste)
                {
                    grootste = arrayVanTien[i];
                }
            }

            return grootste;
        }

        private static int CalcArraySom(int[] arrayVanTien)
        {
            int som = 0;

            for(int i = 0; i < arrayVanTien.Length; i++)
            {
                som += arrayVanTien[i];
            }

            return som;
        }

        private static int[] InitArray(int sizeArray)
        {
            //declare var & rng
            Random rand = new Random();
            int[] arrayVanTien = new int [sizeArray];

            //init array
            for (int i = 0; i < sizeArray; i++)
            {
                arrayVanTien[i] = rand.Next(0, 101);
            }

            return arrayVanTien;
        }
    }
}
