using System;
using System.Collections.Generic;

namespace Politiek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Politiek\n");

            //init country
            Land belgie = new Land();

            Console.WriteLine(belgie);

            //populate spots
            President denPresident = new President() { Naam = "Jakker den President" };

            List<Minister> denMinisters = new List<Minister>();
            denMinisters.Add(new Minister { Naam = "Joske den eerste"});
            denMinisters.Add(new Minister { Naam = "Jan den tweede" });
            denMinisters.Add(new Minister { Naam = "Jan den derde" });
            //enter spots into country
            belgie.MaakRegering(denPresident, denMinisters);

            Console.WriteLine(belgie);
        }
    }
}
