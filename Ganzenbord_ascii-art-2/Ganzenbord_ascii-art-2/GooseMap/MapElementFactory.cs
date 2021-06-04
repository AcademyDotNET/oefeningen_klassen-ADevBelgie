using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    class MapElementFactory: IMapElementFactory
    {
        public MapElement Build(Spaces toBuild, int x, int y)
        {
            switch (toBuild)
            {
                case Spaces.Static:
                    return new Static(Spaces.Static,  x,  y);
                case Spaces.Goose:
                    return new Goose(Spaces.Goose, x, y);
                case Spaces.Bridge:
                    return new Bridge(Spaces.Bridge, x, y);
                case Spaces.Inn:
                    return new Inn(Spaces.Inn, x, y);
                case Spaces.Well:
                    return new Well(Spaces.Well, x, y);
                case Spaces.Maze:
                    return new Maze(Spaces.Maze, x, y);
                case Spaces.Prison:
                    return new Prison(Spaces.Prison, x, y);
                case Spaces.Death:
                    return new Death(Spaces.Death, x, y);
                case Spaces.End:
                    return new End(Spaces.End, x, y);
                default:
                    return new Unknown(Spaces.Unknown, x, y);
            }
        }
    }
}
