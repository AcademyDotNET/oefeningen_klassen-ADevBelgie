﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    interface IMapElementFactory
    {
        public MapElement Build(Spaces toBuild, int x, int y);
    }
}
