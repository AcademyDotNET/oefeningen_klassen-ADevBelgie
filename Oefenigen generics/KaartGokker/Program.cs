using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace KaartGokker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speelkaarten\n");

            //init deck
            Deck deck = new Deck();

            deck.SchuddenKaartenSpel();

            while (deck.KaartenSpel.Count > 0)
            {
                deck.TrekBovensteKaart();
                Console.ReadLine();
            }
        }
    }
}
