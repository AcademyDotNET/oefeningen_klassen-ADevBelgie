using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    public enum Spaces { Static, Goose, Bridge, Inn, Well, Maze, Prison, Death, End};
    class MapElement
    {
        public MapElement(Spaces currentSpace)
        {
            this.CurrentSpace = currentSpace;
        }
        public Spaces CurrentSpace { get; set; }
    }
}
