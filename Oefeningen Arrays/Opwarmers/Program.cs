using System;

namespace Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opwarmers\n");

            //init RNG
            Random rand = new Random();

            //Maak een array gevuld met de getallen 0 tot 10
            int[] arrayVanTien = VullenArrayVanTien();
            printArray(arrayInt: arrayVanTien);

            //Maak een array gevuld met de getallen van 100 tot 1
            int[] arrayVanHonderd = VullenArrayVanHonderd();
            printArray(arrayInt: arrayVanHonderd);

            //Maak een array gevuld met de letters a tot z
            char[] arrayVanATotZ = VullenArrayVanATotZ();
            printArray(arrayChar: arrayVanATotZ);

            //Maak een array gevuld met willekeurige getallen tussen 1 en 100 (de array is 20 lang)
            int[] array20MetRandom = VullenArray20MetRandom();
            printArray(arrayInt: array20MetRandom);

            //Maak een array gevuld met afwisselend true en false (de array is 30 lang)
            bool[] arrayVanafwisselend = VullenarrayVanafwisselend();
            printArray(arrayBool: arrayVanafwisselend);
            
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
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
        }

        private static bool[] VullenarrayVanafwisselend()
        {
            bool[] arrayVanafwisselend = new bool[30];

            for (int i = 0; i < 20; i++)
            {
                arrayVanafwisselend[i] = (i % 2 == 0);
            }

            return arrayVanafwisselend;
        }

        private static int[] VullenArray20MetRandom()
        {
            Random rand = new Random();
            int[] array20MetRandom = new int[20];

            for (int i = 0; i < 20; i++)
            {
                array20MetRandom[i] = rand.Next(0, 101);
            }

            return array20MetRandom;
        }

        private static char[] VullenArrayVanATotZ()
        {
            char[] arrayVanHonderd = new char[26];

            for (int i = 97; i <= 122; i++)
            {
                arrayVanHonderd[i-97] = (char)i;
            }

            return arrayVanHonderd;
        }

        private static int[] VullenArrayVanHonderd()
        {
            int[] arrayVanHonderd = new int[101];

            for (int i = 0; i < 100; i++)
            {
                arrayVanHonderd[i] = 100 - i;
            }

            return arrayVanHonderd;
        }

        private static int[] VullenArrayVanTien()
        {
            int[] arrayVanTien = new int[11];

            for(int i = 0; i <= 10; i++)
            {
                arrayVanTien[i] = i;
            }

            return arrayVanTien;
        }
    }
}
