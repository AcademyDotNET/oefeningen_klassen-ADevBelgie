using System;

namespace EXTRA_Deel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deel 1\n");

            //user input
            Console.WriteLine("give us your number");
            string userInputS = Console.ReadLine();
            int userInput = Convert.ToInt32(userInputS);

            //user output
            //Toon alle natuurlijke getallen van 1 tot n.
            //Toon alle natuurlijke getallen van n tot 1.
            if (userInput > 1)
            {
                Console.WriteLine($"alle natuurlijke getallen tussen {userInput} en 1");
                for (int i = 1; i < userInput; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (userInput < 1)
            {
                Console.WriteLine($"alle natuurlijke getallen tussen {userInput} en 1");
                for (int i = 1; i > userInput; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine($"er zijn geen natuulijke getallen tussen {userInput} en 1");
            }

            //Toon alle even getallen tussen 1 en 100.
            //Toon alle oneven getallen tussen 1 en 100.
            Console.Write("\nEven numbers: ");
            for (int i = 0; i <= 100; i++)
            {
                if(i%2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\nOdd numbers: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }

            //Toon de som van alle getallen van 1 tot n(dus 1 + 2 + 3 + 4 + ...+n).
            int sumTotal = 0;
            int sumTotalEven = 0;
            int sumTotalOdd = 0;
            if (userInput > 1)
            {
                for (int i = 1; i <= userInput; i++)
                {
                    sumTotal += i;
                    if (i % 2 == 0)
                    {
                        sumTotalEven += i;
                    }
                    else
                    {
                        sumTotalOdd += i;
                    }
                }
            }
            else if (userInput < 1)
            {
                for (int i = 1; i >= userInput; i--)
                {
                    sumTotal += i;
                    if (i % 2 == 0)
                    {
                        sumTotalEven += i;
                    }
                    else
                    {
                        sumTotalOdd += i;
                    }
                }
            }

            Console.WriteLine($"\nsom totaal: {sumTotal}");
            Console.WriteLine($"\nsom totaal even: {sumTotalEven}");
            Console.WriteLine($"\nsom totaal oneven: {sumTotalOdd}");

            //(PRO) Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).
            Console.WriteLine($"\naantal digits: {userInputS.Length}");


        }
    }
}

/*
 
    Toon alle natuurlijke getallen van 1 tot n.
    Toon alle natuurlijke getallen van n tot 1.
    Toon alle even getallen tussen 1 en 100.
    Toon alle oneven getallen tussen 1 en 100.
    Toon de som van alle getallen van 1 tot n (dus 1+2+3+4+...+n).
    Toon de som van alle even getallen van 1 tot n.
    Toon de som van alle oneven getallen van 1 tot n.
    (PRO) Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).
    Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.
    Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot n (tip: char c = Convert.ToChar(65); zal hoofdletter A tonen).
    Toon het alfabet van a tot z.
    Schrijf een programma dat de macht van een getal toont. De gebruiker voert eerst het getal in, gevolgd door de macht (bv. 2 en 4 zal als resultaat 16 geven (2 tot de 4e macht)). Merk op dat je geen gebruik mag maken van Math.Pow. Je dient zelf de vermenigvuldiging helemaal (m.b.v. loops) uit te voeren.
    Schrijf een programma een getal n ontbindt in factoren. Factoren zijn de getallen waardoor je n kan delen zonder rest (van bijvoorbeeld het getal 100 zijn de factoren 1, 2, 4, 5, 10, 20, 25, 50 en 100).
    Schrijf een programma dat controleert of een getal priem is of niet.
    Toon ale priemgetallen van 1 tot n.
    Toon de reeks van Fibonacci tot n termen.

 */
