using System;

namespace Mapmaker_all_in_one_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Map maker\n");

            WallElement steen1 = new WallElement() { Location = new Point(5, 5) };
            steen1.Paint();

            //kamer met vier muren
            KamerTekenen(5, 5, 30, 20);

            //Tafel en stoelen
            Tafel tafelKlein = new Tafel() { Location = new Point(12, 12), Breedte = 5, Lengte = 5 };
            tafelKlein.Paint();

            Stoel stoelTafelKlein = new Stoel() { Location = new Point(14, 11), Breedte = 1, Lengte = 1 };
            Stoel stoelTafelKlein2 = new Stoel() { Location = new Point(14, 17), Breedte = 1, Lengte = 1 };
            stoelTafelKlein.Paint();
            stoelTafelKlein2.Paint();


            Console.ReadLine();
        }

        private static void KamerTekenen(int x, int y, int xLengte, int yLengte)
        {
            Wall muurNoord = new Wall(true, x, y, xLengte);
            muurNoord.Paint();
            Wall muurWest = new Wall(false, x, y, yLengte);
            muurWest.Paint();
            Wall muurOost = new Wall(false, x+xLengte-1, y, yLengte);
            muurOost.Paint();
            Wall muurZuid = new Wall(true, x, y+yLengte-1, xLengte);
            muurZuid.Paint();
        }
    }
}
