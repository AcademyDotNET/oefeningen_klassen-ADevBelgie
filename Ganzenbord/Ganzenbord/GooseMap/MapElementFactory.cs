using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class MapElementFactory: IMapElementFactory
    {
        public MapElement Build(Spaces toBuild)
        {
            switch (toBuild)
            {
                case Spaces.Static:
                    return new Static(Spaces.Static);
                case Spaces.Goose:
                    return new Goose(Spaces.Goose);
                case Spaces.Bridge:
                    return new Bridge(Spaces.Bridge);
                case Spaces.Inn:
                    return new Inn(Spaces.Inn);
                case Spaces.Well:
                    return new Well(Spaces.Well);
                case Spaces.Maze:
                    return new Maze(Spaces.Maze);
                case Spaces.Prison:
                    return new Prison(Spaces.Prison);
                case Spaces.Death:
                    return new Death(Spaces.Death);
                case Spaces.End:
                    return new End(Spaces.End);
                default:
                    return new Unknown(Spaces.Unknown);
            }
        }
    }
}
