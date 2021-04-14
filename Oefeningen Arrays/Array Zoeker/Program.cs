using System;

namespace Array_Zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Zoeker\n");

            //init
            int[] arrayA = VulArray(10);
            int userInputI;

            //print array
            printArray(arrayInt: arrayA);

            //user input
            Console.WriteLine("\nWelk nummer wil je verwijderen?");
            userInputI = Convert.ToInt32(Console.ReadLine());

            //search and destroy
            ZoekenNummerArray(userInputI, arrayA);

            //print array
            printArray(arrayInt: arrayA);
        }

        private static void ZoekenNummerArray(int userInputI, int[] arrayA)
        {
            //init
            int arraySize = arrayA.Length;
            bool numberFound = false;
            bool multipleNumberFound = true;
            int amountNumbersFound = 1;

            //look for numbers
            while(multipleNumberFound)
            {
                multipleNumberFound = false;
                numberFound = false;
                amountNumbersFound--;

                for (int i = 0; i < arraySize; i++)
                {
                    if (arrayA[i] == userInputI && !numberFound)
                    {
                        arrayA[i] = arrayA[(i + 1 < arraySize) ? i + 1 : i]; // make sure to not go out of bound
                        numberFound = true;
                        amountNumbersFound++;
                    }
                    else if (numberFound)
                    {
                        //check for multiple entities of found number
                        if (arrayA[i] == userInputI && !multipleNumberFound)
                        {
                            multipleNumberFound = true;
                            amountNumbersFound++;
                        }

                        arrayA[i] = arrayA[(i + 1 < arraySize) ? i + 1 : i]; // make sure to not go out of bound
                    }
                }
            }

            //change last numbers to -1
            if (numberFound)
            {
                for (int j = 0;  j < amountNumbersFound; j++)
                {
                    arrayA[arraySize - j -1] = -1;
                }
            }
            Console.WriteLine($"Amount of numbers removed: {amountNumbersFound}\n");
        }

        private static int[] VulArray(int arraySize)
        {
            //declare vars
            int[] arrayToFill = new int[arraySize];
            Random rand = new Random();

            //init array
            for (int i = 0; i < arraySize; i++)
            {
                arrayToFill[i] = rand.Next(0, 101);
            }

            return arrayToFill;
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
    }
}

//Maak een programma dat eerst weer aan de gebruiker om 10 waarden vraagt die in een array worden gezet.

//Vervolgens vraagt het programma welke waarde verwijderd moet worden. Wanneer de gebruiker hierop antwoordt met een nieuwe waarde dan zal deze nieuw ingevoerde waarde in de array gezocht worden. Indien deze gevonden wordt dan wordt deze waarde uit de array verwijderd en worden alle waarden die erachter komen met een plaatsje naar links opgeschoven, zodat achteraan de array terug een lege plek komt.

//Deze laatste plek krijgt de waarde -1.

//Toon vervolgens alle waarden van de array.

//Indien de te zoeken waarde meer dan 1 keer voorkomt, wordt enkel de eerst gevonden waarde verwijderd.

