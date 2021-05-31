using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class GooseBoard
    {
        public GooseBoard()
        {
            Init();
        }
        public MapElement[] GooseBoardArray { get; set; } = new MapElement[64];
        private void Init()
        {
            IMapElementFactory MEFactory = new MapElementFactory();
            for (int i = 0; i < GooseBoardArray.Length; i++)
            {
                GooseBoardArray[i] = MEFactory.Build(Spaces.Static);
            }
            GooseBoardArray[5] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[9] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[14] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[18] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[23] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[27] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[32] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[36] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[41] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[45] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[50] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[54] = MEFactory.Build(Spaces.Goose);
            GooseBoardArray[59] = MEFactory.Build(Spaces.Goose);

            GooseBoardArray[6] = MEFactory.Build(Spaces.Bridge);
            GooseBoardArray[19] = MEFactory.Build(Spaces.Inn);
            GooseBoardArray[31] = MEFactory.Build(Spaces.Well);
            GooseBoardArray[42] = MEFactory.Build(Spaces.Maze);
            GooseBoardArray[52] = MEFactory.Build(Spaces.Prison);
            GooseBoardArray[58] = MEFactory.Build(Spaces.Death);
            GooseBoardArray[63] = MEFactory.Build(Spaces.End);
        }
    }
}
