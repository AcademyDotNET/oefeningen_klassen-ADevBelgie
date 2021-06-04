using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_ascii_art_2
{
    class Output :IOutput
    {
        public void Write(string toOut)
        {
            Console.Write(toOut);
        }
        public void WriteLine(string toOut)
        {
            Console.WriteLine(toOut);
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void SetCursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        public (int, int) GetCursorPosition()
        {
            return Console.GetCursorPosition();
        }
        public void ForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public void BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
