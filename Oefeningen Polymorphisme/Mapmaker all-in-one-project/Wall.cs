using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    class Wall: MapObject
    {
        public Wall(bool horizontal, int startx, int starty, int size)
        {
            price *= size;
            Location = new Point( startx, starty );
            _horizontal = horizontal;
            _size = size;
            WallPosition();
        }
        private bool _horizontal;
        private int _size;

        List<WallElement> wall = new List<WallElement>();
        public void WallPosition()
        {
            wall.Clear();
            for (int i = 0; i < _size; i++)
            {
                if (_horizontal)
                {
                    wall.Add(new WallElement() { Location = new Point(Location.X + i, Location.Y) });
                }
                else
                {
                    wall.Add(new WallElement() { Location = new Point(Location.X, Location.Y + i) });
                }
            }
        }
        public override void Paint()
        {
            //update wall elements if location changed wall changed
            if (!wall[0].Location.Equals(Location))
            {
                WallPosition();
            }
            //print elements
            foreach (var wallPart in wall)
            {
                wallPart.Paint();
            }
        }
    }
}
