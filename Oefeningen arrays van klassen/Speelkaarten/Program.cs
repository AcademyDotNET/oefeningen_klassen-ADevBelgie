using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speelkaarten\n");

            //init deck
            List<Speelkaart> deck = new List<Speelkaart>();

            for (int y = 0; y < 4; y++)
            {
                for (int i = 0; i < 13; i++)
                {
                    deck.Add(new Speelkaart() { Getal = (Getal)i, Suite = (Suite)y });
                }
            }

            //game
            Random rand = new Random();
            int currentRandom;

            for (int i = 52 - 1; i >= 0; i--)
            {
                currentRandom = rand.Next(0,i);
                Console.WriteLine("\nWillekeurige kaart is: ");
                Console.WriteLine($"{Enum.GetName(typeof(Getal), deck[currentRandom].Getal)} van {deck[currentRandom].Suite}");
                //{deck[currentRandom].Getal}  
                //{Enum.GetName(Getal, deck[currentRandom].Getal)}
                //{Enum.GetName(nameof(Getal), deck[currentRandom].Getal)}
                //{nameof(deck[currentRandom].Getal)}
                //{Enum.GetName(typeof(Getal), deck[currentRandom].Getal)}
                deck.RemoveAt(currentRandom);
                Console.ReadLine();
            }
        }
    }
}

//Maak een klasse Speelkaart die je kan gebruiken om een klassieke kaart met getal en "kleur" voor te stellen.

//Een kaart heeft 2 eigenschappen, een getal van 1 tot en met 13 (boer=11, koningin = 12, heer = 13):
//Een kleur, de zogenaamde suite. Deze stel je voor via een enumtype en kan als waarden Schoppen, Harten, Klaveren of Ruiten zijn.
//Schrijf nu 2 loops die de 52 kaarten van een standaard pak in een List<SpeelKaart> lijst plaatst.

//Maak nu een applicatie die telkens een willekeurige kaart uit de deck trekt en deze aan de gebruiker toont. De kaart wordt na het tonen dus uit de lijst verwijderd. Door met een willekeurig getal te werken hoef je dus je deck niet te schudden.
