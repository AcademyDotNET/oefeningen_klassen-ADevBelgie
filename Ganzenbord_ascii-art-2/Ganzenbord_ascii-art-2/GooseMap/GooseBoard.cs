using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    class GooseBoard: IGooseBoard
    {
        public GooseBoard()
        {
            InitGooseBoardArray();
        }
        public MapElement[] GooseBoardArray { get; set; } = new MapElement[64];
        private void InitGooseBoardArray()
        {
            IMapElementFactory MEFactory = new MapElementFactory();

            //format parameters CurrentSpace, Location.X, Location.Y
            GooseBoardArray[0] = MEFactory.Build(Spaces.Static, 8, 22);
            GooseBoardArray[1] = MEFactory.Build(Spaces.Static, 20, 20);
            GooseBoardArray[2] = MEFactory.Build(Spaces.Static, 26, 22);
            GooseBoardArray[3] = MEFactory.Build(Spaces.Static, 32, 20);
            GooseBoardArray[4] = MEFactory.Build(Spaces.Static, 38, 22);
            GooseBoardArray[5] = MEFactory.Build(Spaces.Goose, 44, 21);

            GooseBoardArray[6] = MEFactory.Build(Spaces.Bridge, 50, 22);//bridge
            GooseBoardArray[7] = MEFactory.Build(Spaces.Static, 56, 20);
            GooseBoardArray[8] = MEFactory.Build(Spaces.Static, 62, 22);
            GooseBoardArray[9] = MEFactory.Build(Spaces.Goose, 68, 21);

            GooseBoardArray[10] = MEFactory.Build(Spaces.Static, 74, 22);
            GooseBoardArray[11] = MEFactory.Build(Spaces.Static, 80, 20);
            GooseBoardArray[12] = MEFactory.Build(Spaces.Static, 86, 18);
            GooseBoardArray[13] = MEFactory.Build(Spaces.Static, 92, 16);
            GooseBoardArray[14] = MEFactory.Build(Spaces.Goose, 98, 14);

            GooseBoardArray[15] = MEFactory.Build(Spaces.Static, 98, 10);
            GooseBoardArray[16] = MEFactory.Build(Spaces.Static, 92, 8);
            GooseBoardArray[17] = MEFactory.Build(Spaces.Static, 86, 6);
            GooseBoardArray[18] = MEFactory.Build(Spaces.Goose, 80, 4);

            GooseBoardArray[19] = MEFactory.Build(Spaces.Inn, 74, 2);//Inn
            GooseBoardArray[20] = MEFactory.Build(Spaces.Static, 68, 4);
            GooseBoardArray[21] = MEFactory.Build(Spaces.Static, 62, 2);
            GooseBoardArray[22] = MEFactory.Build(Spaces.Static, 56, 4);
            GooseBoardArray[23] = MEFactory.Build(Spaces.Goose, 50, 2);

            GooseBoardArray[24] = MEFactory.Build(Spaces.Static, 44, 4);
            GooseBoardArray[25] = MEFactory.Build(Spaces.Static, 38, 2);
            GooseBoardArray[26] = MEFactory.Build(Spaces.Static, 32, 4);
            GooseBoardArray[27] = MEFactory.Build(Spaces.Goose, 26, 2);

            GooseBoardArray[28] = MEFactory.Build(Spaces.Static, 20, 4);
            GooseBoardArray[29] = MEFactory.Build(Spaces.Static, 14, 6);
            GooseBoardArray[30] = MEFactory.Build(Spaces.Static, 8, 8);
            GooseBoardArray[31] = MEFactory.Build(Spaces.Well, 2, 10);//well
            GooseBoardArray[32] = MEFactory.Build(Spaces.Goose, 2, 14);

            GooseBoardArray[33] = MEFactory.Build(Spaces.Static, 8, 16);
            GooseBoardArray[34] = MEFactory.Build(Spaces.Static, 14, 18);
            GooseBoardArray[35] = MEFactory.Build(Spaces.Static, 20, 16);
            GooseBoardArray[36] = MEFactory.Build(Spaces.Goose, 26, 18);

            GooseBoardArray[37] = MEFactory.Build(Spaces.Static, 32, 16);
            GooseBoardArray[38] = MEFactory.Build(Spaces.Static, 38, 18);
            GooseBoardArray[39] = MEFactory.Build(Spaces.Static, 44, 16);
            GooseBoardArray[40] = MEFactory.Build(Spaces.Static, 50, 18);
            GooseBoardArray[41] = MEFactory.Build(Spaces.Goose, 56, 16);

            GooseBoardArray[42] = MEFactory.Build(Spaces.Maze, 62, 18);//maze
            GooseBoardArray[43] = MEFactory.Build(Spaces.Static, 68, 16);
            GooseBoardArray[44] = MEFactory.Build(Spaces.Static, 74, 18);
            GooseBoardArray[45] = MEFactory.Build(Spaces.Goose, 80, 16);

            GooseBoardArray[46] = MEFactory.Build(Spaces.Static, 86, 14);
            GooseBoardArray[47] = MEFactory.Build(Spaces.Static, 92, 12);
            GooseBoardArray[48] = MEFactory.Build(Spaces.Static, 86, 10);
            GooseBoardArray[49] = MEFactory.Build(Spaces.Static, 80, 8);
            GooseBoardArray[50] = MEFactory.Build(Spaces.Goose, 74, 6);

            GooseBoardArray[51] = MEFactory.Build(Spaces.Static, 68, 8);
            GooseBoardArray[52] = MEFactory.Build(Spaces.Prison, 62, 6);//prison
            GooseBoardArray[53] = MEFactory.Build(Spaces.Static, 56, 8);
            GooseBoardArray[54] = MEFactory.Build(Spaces.Goose, 50, 6);


            GooseBoardArray[55] = MEFactory.Build(Spaces.Static, 44, 8);
            GooseBoardArray[56] = MEFactory.Build(Spaces.Static, 38, 6);
            GooseBoardArray[57] = MEFactory.Build(Spaces.Static, 32, 8);
            GooseBoardArray[58] = MEFactory.Build(Spaces.Death, 26, 6);//death
            GooseBoardArray[59] = MEFactory.Build(Spaces.Goose, 20, 8);

            GooseBoardArray[60] = MEFactory.Build(Spaces.Static, 14, 10);
            GooseBoardArray[61] = MEFactory.Build(Spaces.Static, 8, 12);
            GooseBoardArray[62] = MEFactory.Build(Spaces.Static, 14, 14);
            GooseBoardArray[63] = MEFactory.Build(Spaces.End, 30, 12);//end
        }
    }
}
