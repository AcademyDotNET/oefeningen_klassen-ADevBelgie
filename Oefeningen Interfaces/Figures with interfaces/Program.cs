using System;

namespace Figures_with_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric figures");

            Vierkant vierkantje = new Vierkant(3);
            Rechthoek rechthoekje = new Rechthoek();
            Driehoek driehoekje = new Driehoek();

            //empty except for vierkantje
            Console.WriteLine(vierkantje.BerekenOppervlakte());
            Console.WriteLine(rechthoekje.BerekenOppervlakte());
            Console.WriteLine(driehoekje.BerekenOppervlakte());

            vierkantje.Hoogte = 3;
            vierkantje.Breedte = 100;
            rechthoekje.Hoogte = 3;
            rechthoekje.Breedte = 100;
            driehoekje.Hoogte = 3;
            driehoekje.Breedte = 3;

            //all assigned new values
            Console.WriteLine(vierkantje.BerekenOppervlakte());
            Console.WriteLine(rechthoekje.BerekenOppervlakte());
            Console.WriteLine(driehoekje.BerekenOppervlakte());
        }
    }
}
