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

        public ConsoleKey GetKey()
        {
            ClearKeyBuffer();
            ClearCurrentConsoleLine();
            UserInputKey = Console.ReadKey().Key; //this line seems to eat character when ESC is pressed

            if (UserInputKey == ConsoleKey.Escape)
            {
                Console.Write("A");//added character here because code eats it somewhere
                Console.SetCursorPosition(Console.GetCursorPosition().Left, Console.GetCursorPosition().Top+1);
            }
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
            System.Threading.Thread.Sleep(180);
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
    }
}
