using System;
using System.Collections.Generic;

namespace Mapmaker_all_in_one_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Map maker\n");

            List<MapObject> Salon = new List<MapObject>();

            //kamer met vier muren
            KamerToevoegen(Salon, 5, 5, 30, 20);
            
            //Tafel en stoelen
            Tafel tafelKlein = new Tafel() { Location = new Point(12, 12), Breedte = 5, Lengte = 5 };
            Salon.Add(tafelKlein);

            Stoel stoelTafelKlein = new Stoel() { Location = new Point(14, 11), Breedte = 1, Lengte = 1 };
            Stoel stoelTafelKlein2 = new Stoel() { Location = new Point(14, 17), Breedte = 1, Lengte = 1 };
            Salon.Add(stoelTafelKlein);
            Salon.Add(stoelTafelKlein2);

            foreach (var Object in Salon)
            {
                Object.Paint();
            }

            Console.ReadLine();
            Console.Clear();

            //Beweeg kaart naar beneder
            //foreach (var Object in Salon)
            //{
            //    Object.Location = new Point(Object.Location.X, Object.Location.Y + 10);
            //}
            //foreach (var Object in Salon)
            //{
            //    Object.Paint();
            //}
            for (int i = 0; i < Salon.Count; i++)
            {
                Salon[i].Location = new Point(Salon[i].Location.X, Salon[i].Location.Y + 10);
                Salon[i].Paint();
            }
            Console.ReadLine();
        }

        private static void KamerToevoegen(List<MapObject> Kamer, int x, int y, int xLengte, int yLengte)
        {
            Wall muurNoord = new Wall(true, x, y, xLengte);
            Wall muurWest = new Wall(false, x, y, yLengte);
            Wall muurOost = new Wall(false, x+xLengte-1, y, yLengte);
            Wall muurZuid = new Wall(true, x, y+yLengte-1, xLengte);

            //voeg vier muren toe aan List "Kamer"
            Kamer.Add(muurNoord);
            Kamer.Add(muurWest);
            Kamer.Add(muurOost);
            Kamer.Add(muurZuid);
        }
    }
}
