using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figuren\n");

            Driehoek kleineDriehoek = new Driehoek();
            Rechthoek groteRechthoek = new Rechthoek();
            Rechthoek slechteRechthoek = new Rechthoek();

            kleineDriehoek.Basis = 10;
            kleineDriehoek.Hoogte = 10;
            kleineDriehoek.ToonOppervlakte();

            groteRechthoek.Breedte = 10;
            groteRechthoek.Lengte = 10;
            groteRechthoek.ToonOppervlakte();

            slechteRechthoek.Breedte = -20;
            slechteRechthoek.Lengte = -5;
            slechteRechthoek.ToonOppervlakte();
        }
    }
}
