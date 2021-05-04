using System;
using System.Collections.Generic;

namespace GenericListTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GenericListTester\n");
            var lijstInt = new ListEenderType<int>();
            var lijstString = new ListEenderType<string>();
            var lijstDouble = new List<double>();

            lijstDouble.Add(100);
            lijstDouble.Add(150);
            lijstDouble.Add(180);

            lijstInt.Add(100);
            lijstInt.Add(150);
            lijstInt.Add(200);

            lijstString.Add("ABC");
            lijstString.Add("DEF");
            lijstString.Add("GHI");
            lijstString.Remove("DEF");

            Console.WriteLine(lijstString);
            Console.WriteLine(lijstInt);

            foreach (var item in lijstDouble)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Maak een programma (klasse) dat voor elke mogelijke lijst van types kan gebruiken. 
//Aan deze lijst willen we dan items kunnen toevoegen maar ook uit kunnen verwijderen
//(denk meerdere methodes) 
//Ik wil ook een optie om de items in de lijst weer te geven, waarbij ik dan 
//elk item ook individueel kan benaderen.
//PT2: Maak dit mogelijk voor objecten. Stel dat ik een lijst v studenten heb wil ik voor
//elke specifieke student in de lijst de waardes kunnen aanpassen. 
//(ik selecteer een student en bewerk deze)