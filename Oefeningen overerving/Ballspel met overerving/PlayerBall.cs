using System;
using System.Collections.Generic;
using System.Text;

namespace Ballspel_met_overerving
{
    class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy = -1;
                    vx = 0;
                    break;
                case ConsoleKey.DownArrow:
                    vy = 1;
                    vx = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    vx = -1;
                    vy = 0;
                    break;
                case ConsoleKey.RightArrow:
                    vx = 1;
                    vy = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
