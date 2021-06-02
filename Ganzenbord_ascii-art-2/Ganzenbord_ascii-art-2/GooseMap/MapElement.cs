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
        public MapElement(Spaces currentSpace)
        {
            this.CurrentSpace = currentSpace;
        }
        public Spaces CurrentSpace { get; set; }
    }
}
