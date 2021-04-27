using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    abstract class MapObject
    {
        protected Point location;
        protected double price;
        protected char drawChar;

        //Teken object in de console
        public abstract void Paint();
    }
}
