using System;

namespace ArrayOefener_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayOefener 2\n");

            //init
            int[] arrayA = VulArray(5);
            int[] arrayB = VulArray(5);

            //math
            int[] arrayC = sumArray(arrayA, arrayB);

            //output
            Console.WriteLine(string.Join(" ", arrayA) + "\n+ ");
            Console.WriteLine(string.Join(" ", arrayB) + "\n= ");
            Console.WriteLine(string.Join(" ", arrayC));

            Console.ReadLine();
        }

        private static int[] sumArray(int[] arrayA, int[] arrayB)
        {
            int[] arrayC = new int [arrayA.Length];

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayC[i] = arrayA[i] + arrayB[i];
            }

            return arrayC;
        }

        private static int[] VulArray(int arraySize)
        {
            //declare vars
            int[] arrayToFill = new int [arraySize];
            Random rand = new Random();

            //init array
            for(int i = 0; i < arraySize; i++)
            {
                arrayToFill[i] = rand.Next(0, 101);
            }

            return arrayToFill;
        }
    }
}
