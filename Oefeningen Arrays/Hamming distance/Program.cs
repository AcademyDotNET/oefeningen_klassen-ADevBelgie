using System;

namespace Hamming_distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hamming distance\n");

            //fill arrays
            char[] hammingReeks1 = VulArray(10);
            char[] hammingReeks2 = VulArray(10);

            //print arrays
            printArray(arrayChar: hammingReeks1);
            printArray(arrayChar: hammingReeks2);

            //compare and print result
            for(int i = 0; i < hammingReeks1.Length; i++)
            {
                if(hammingReeks1[i] == hammingReeks2[i])
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("^");
                }
            }
        }

        private static void printArray(bool[] arrayBool = null, int[] arrayInt = null, char[] arrayChar = null)
        {
            if (arrayBool != null)
            {
                var array = arrayBool;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayInt != null)
            {
                var array = arrayInt;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayChar != null)
            {
                var array = arrayChar;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}");//removed commas from original
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
        }

        private static char[] VulArray(int arraySize)
        {
            //declare vars
            char[] arrayToFill = new char[arraySize];
            Random rand = new Random();
            int randomNumber;

            //init array
            for (int i = 0; i < arraySize; i++)
            {
                randomNumber = rand.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        arrayToFill[i] = 'G';
                        break;
                    case 1:
                        arrayToFill[i] = 'A';
                        break;
                    case 2:
                        arrayToFill[i] = 'C';
                        break;
                    case 3:
                        arrayToFill[i] = 'T';
                        break;
                    default:
                        arrayToFill[i] = 'X';
                        break;
                }
            }

            return arrayToFill;
        }
    }
}
