using System;

namespace Array_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Viewer\n");

            int[] array = { 15, 6, 9 };
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6 };
            VisualiseerArray(arrayInt: array);
            VisualiseerArray(arrayInt: array2);
        }

        private static void VisualiseerArray(bool[] arrayBool = null, int[] arrayInt = null, char[] arrayChar = null)
        {
            if (arrayBool != null)
            {
                var array = arrayBool;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}\t");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayInt != null)
            {
                var array = arrayInt;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}\t");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayChar != null)
            {
                var array = arrayChar;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}\t");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
        }
    }
}

//Maak een programma dat een methode VisualiseerArray implementeert. De methode zal een array (type int) als parameter hebben en niets teruggeven (void). Echter, de methode zal met behulp van Write() de array, van eender welke grootte, op het scherm tonen. Tussen ieder element van dezelfde rij dient een tab (‘\t’) gezet te worden. Je dient in de methode gebruik te maken van een for-loop. Voorbeeld van main:

//int[] array = { 15, 6, 9 };
//int[] array2 = { 0, 1, 2, 3, 4, 5, 6 };
//VisualiseerArray(array);
//VisualiseerArray(array2);

//Geeft volgende output:

//15    6    9
//0    1    2    3    4    5    6
