using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    interface IMapElementFactory
    {
        public MapElement Build(Spaces toBuild);
    }
}
