using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    public enum Spaces { Static, Goose, Bridge, Inn, Well, Maze, Prison, Death, End, Unknown};
    abstract class MapElement
    {
        public MapElement(Spaces currentSpace, int x, int y)
        {
            this.CurrentSpace = currentSpace;
            Location = new LocationConsole() { X = x, Y = y};
        }
        public Spaces CurrentSpace { get; set; }
        public LocationConsole Location { get; set; }
//        public string BaseSchape { get;} = 
//$@"____
///    \
///      \
//\      /
//\____/";
    }
}
