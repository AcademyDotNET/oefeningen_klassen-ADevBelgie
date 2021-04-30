using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Settings
    {
        public Settings()
        {
            MoveUpKey= ConsoleKey.Z; 
            MoveDownKey= ConsoleKey.S;
            MoveLeftKey = ConsoleKey.Q;
            MoveRightKey = ConsoleKey.D;
            ShootLeftKey = ConsoleKey.A;
            ShootRightKey = ConsoleKey.E;
        }
        public ConsoleKey MoveUpKey { get; set; }
        public ConsoleKey MoveDownKey { get; set; }
        public ConsoleKey MoveLeftKey { get; set; }
        public ConsoleKey MoveRightKey { get; set; }
        public ConsoleKey ShootLeftKey { get; set; }
        public ConsoleKey ShootRightKey { get; set; }

        public override string ToString()
        {
            string totalString = $"1. MoveUpKey = {MoveUpKey}\n";
            totalString += $"2. MoveDownKey = {MoveDownKey}\n";
            totalString += $"3. MoveLeftKey = {MoveLeftKey}\n";
            totalString += $"4. MoveRightKey = {MoveRightKey}\n";
            totalString += $"5. ShootLeftKey = {ShootLeftKey}\n";
            totalString += $"6. ShootRightKey = {ShootRightKey}";
            return totalString;
        }
    }
}
