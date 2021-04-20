using System;

namespace Sport_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sportspeler\n");

            SpelerBox zwakke = new SpelerBox();
            zwakke.Naam = "zwakke";
            zwakke.RunMarathon();
            zwakke.ShowOffStrength();
            Console.WriteLine();

            SpelerBox sterke = new SpelerBox();
            sterke.Naam = "sterke";
            sterke.StelIn();
            sterke.RunMarathon();
            sterke.ShowOffStrength();

            Console.WriteLine();
            SpelerBox.SimuleerSpeler(zwakke);
            Console.WriteLine();
            SpelerBox.SimuleerSpeler(sterke);
        }
    }
}

//Sport simulator
//Haal je Sport klasse van vorig hoofdstuk boven en voeg volgende statische methode er aan toe (vervang het soort speler door de naam van jouw klasse. Mijn klasse noemde Waterpolospeler)

//Schrijf een methode genaamd: static void SimuleerSpeler(Waterpolospeler testspeler)

//(vervang dus Waterpolospeler door de klasse die je zelf hebt gemaakt)

//De SimuleerSpeler-methode zal beide methoden van je klasse telkens 3x aanroepen m.b.v. een for-loop in de methode (dus in mijn geval 3x GooiBal en 3xWatertrappen)

//Test je methode door 2 objecten aan te maken en telkens mee te geven als parameter.

//Maak een tweede methode static void SimuleerWedstrijd(Waterpolospeler speler1, Waterpolospeler speler2)

//Bij aanroep van de methode verschijnt er op het scherm wie van beide speler zou winnen als ze zouden spelen. Gebruik een random uitkomst om te bepalen over speler 1 of 2 wint. Toon op het scherm "Speler 1 wint." Gevolg door de aanroep van iedere methode van die speler.

//Maak een derde methode static Waterpolospeler BesteSpeler(Waterpolospeler speler1, Waterpolospeler speler2)

//Deze methode gaat ook random bepalen welke speler de beste is. Vervolgens geef je deze speler terug als resultaat. In de main roep je vervolgens iedere methode van dit object aan.
