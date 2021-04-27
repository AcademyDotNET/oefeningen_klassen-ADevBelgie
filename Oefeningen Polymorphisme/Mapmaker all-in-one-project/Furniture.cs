using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    abstract class Furniture : MapObject
    {
        public Furniture()
        {
            drawChar = 'F';
            Lengte = 3;
            Breedte = 3;
        }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        public override void Paint()
        {
            for (int i = 0; i < Lengte; i++)
            {
                for (int y = 0; y < Breedte; y++)
                {
                    Console.SetCursorPosition(Location.X+i, Location.Y+y);
                    Console.Write(drawChar);
                }
            }
        }
    }
}
