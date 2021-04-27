using System;

namespace _PRO__Textbased_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij AP Adventure. Een avontuur voor moedige en minder moedige studenten. Ben je er klaar voor?");

            GameManager theGame = new GameManager();

            //Start gameloop
            while (!theGame.Exit)
            {
                //Beschrijf kamer
                theGame.DescribeLocation();
                //Toon acties
                theGame.ToonActies();
                //Lees actie uit
                theGame.VerwerkActie();

            }
        }
    }
}
