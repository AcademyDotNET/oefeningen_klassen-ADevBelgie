using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    class Point
    {
        public Point(int inx, int iny)
        {
            x = inx;
            y = iny;
        }
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            Point tempObj = (Point)obj;
            if (tempObj.X == this.X && tempObj.Y == this.Y)
            {
                return true;
            }
            return false;
        }
    }
}
