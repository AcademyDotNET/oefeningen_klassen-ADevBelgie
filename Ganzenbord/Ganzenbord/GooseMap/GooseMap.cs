using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    class GooseMap
    {
        public GooseMap()
        {
            Init();
        }
        public MapElement[] GooseBoard { get; set; } = new MapElement[64];
        private void Init()
        {
            for (int i = 0; i < GooseBoard.Length; i++)
            {
                GooseBoard[i] = new MapElement(Spaces.Static);
            }
            GooseBoard[5] = new MapElement(Spaces.Goose);
            GooseBoard[9] = new MapElement(Spaces.Goose);
            GooseBoard[14] = new MapElement(Spaces.Goose);
            GooseBoard[18] = new MapElement(Spaces.Goose);
            GooseBoard[23] = new MapElement(Spaces.Goose);
            GooseBoard[27] = new MapElement(Spaces.Goose);
            GooseBoard[32] = new MapElement(Spaces.Goose);
            GooseBoard[36] = new MapElement(Spaces.Goose);
            GooseBoard[41] = new MapElement(Spaces.Goose);
            GooseBoard[45] = new MapElement(Spaces.Goose);
            GooseBoard[50] = new MapElement(Spaces.Goose);
            GooseBoard[54] = new MapElement(Spaces.Goose);
            GooseBoard[59] = new MapElement(Spaces.Goose);
            GooseBoard[63] = new MapElement(Spaces.End);
        }
    }
}
