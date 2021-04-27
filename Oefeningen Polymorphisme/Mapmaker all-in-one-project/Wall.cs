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
            for (int i = 0; i < size; i++)
            {
                if (horizontal)
                {
                    wall.Add(new WallElement() { Location = new Point(startx + i, starty) });
                }
                else
                {
                    wall.Add(new WallElement() { Location = new Point(startx, starty + i) });
                }
            }
        }

        List<WallElement> wall = new List<WallElement>();

        public override void Paint()
        {
            foreach (var wallPart in wall)
            {
                wallPart.Paint();
            }
        }
    }
}
