using System;
using System.Collections.Generic;
using System.Linq;

namespace Figures_with_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric figures");

            int standaardHoogte = 15;
            int standaardBreedte = 10;
                
            //init rechthoek
            List<Rechthoek> rechthoekObjecten = new List<Rechthoek>();
            for (int i = 0; i < 10; i++)
            {
                rechthoekObjecten.Add(new Rechthoek() { Hoogte = standaardHoogte-i, Breedte = standaardBreedte });
            }

            //sorting 
            rechthoekObjecten = rechthoekObjecten.OrderBy(r => r.BerekenOppervlakte()).ToList();
                
            //output
            Console.WriteLine("sorted list: ");
            foreach (var item in rechthoekObjecten)
            {
                Console.WriteLine(item.BerekenOppervlakte());
            }
        }
    }
}
