using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    class WallElement : MapObject
    {
        public WallElement()
        {
            //defaults
            drawChar = '#';
            price = 10;
        }
        public char DrawChar
        {
            get { return drawChar; }
            set { drawChar = value; }
        }
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
