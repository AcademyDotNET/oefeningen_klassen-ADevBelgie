using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class UserInput: IUserInput
    {
        public ConsoleKey UserInputKey { get; set; }
        public ConsoleKey Escape { get; } = ConsoleKey.Escape;
        public ConsoleKey Backspace { get; } = ConsoleKey.Backspace;
        public ConsoleKey Enter { get; } = ConsoleKey.Enter;
        public ConsoleKey Y { get; } = ConsoleKey.Y;
        public ConsoleKey N { get; } = ConsoleKey.N;
        public ConsoleKey GetKey()
        {
            ClearKeyBuffer();
            ClearCurrentConsoleLine();
            UserInputKey = Console.ReadKey().Key; //this line seems to eat character when ESC is pressed (but not after getting published)

            //if (UserInputKey == ConsoleKey.Escape)//added character here because console eats eat when not published
            //{
            //    Console.Write("A");
            //    Console.SetCursorPosition(Console.GetCursorPosition().Left, Console.GetCursorPosition().Top + 1);
            //}
            return UserInputKey;
        }
        private void ClearCurrentConsoleLine()
        {
            //clears the line in the console, is used for in menu screens or end of game screen
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        private void ClearKeyBuffer()
        {
            // skips previous input chars.
            // this method is here for if people hold down a key for too long causing the button press to go into a buffer.
            System.Threading.Thread.Sleep(100);
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
