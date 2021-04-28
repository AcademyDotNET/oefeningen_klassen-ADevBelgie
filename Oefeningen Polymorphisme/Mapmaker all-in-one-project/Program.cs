using System;
using System.Collections.Generic;
using System.Threading;

namespace Mapmaker_all_in_one_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Map maker\n");

            List<MapObject> Salon = new List<MapObject>();

            //kamer met vier muren
            KamerToevoegen(Salon, 5, 6, 30, 20);
            
            //init and print menu
            Menu menu = new Menu();
            menu.ShowMenu();

            //MoveKamerDown(Salon, 3);

            
            while (true)
            {
                //Teken alle objecten
                foreach (var Object in Salon)
                {
                    Object.Paint();
                }
                menu.ShowMenu();
                menu.GetInput(Salon);

                Thread.Sleep(10);
                
            }
        }

        private static void MoveKamerDown(List<MapObject> Kamer, int moveAmount)
        {
            //zwart maken alle objecten
            Console.ForegroundColor = ConsoleColor.Black;
            foreach (var Object in Kamer)
            {
                Object.Paint();
            }
            //verander locatie objecten.. print deze niet.
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < Kamer.Count; i++)
            {
                Kamer[i].Location = new Point(Kamer[i].Location.X, Kamer[i].Location.Y + moveAmount);
            }
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

            //Tafel en stoelen
            Tafel tafelKlein = new Tafel() { Location = new Point(12, 12), Breedte = 5, Lengte = 5 };
            Kamer.Add(tafelKlein);

            Stoel stoelTafelKlein = new Stoel() { Location = new Point(14, 11), Breedte = 1, Lengte = 1 };
            Stoel stoelTafelKlein2 = new Stoel() { Location = new Point(14, 17), Breedte = 1, Lengte = 1 };
            Kamer.Add(stoelTafelKlein);
            Kamer.Add(stoelTafelKlein2);
        }
    }
}
