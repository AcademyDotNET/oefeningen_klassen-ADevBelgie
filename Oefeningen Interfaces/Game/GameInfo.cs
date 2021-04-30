using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameInfo
    {
        public void DisplayInfo(Settings gameSettings)
        {
            Console.WriteLine($"Game");
            int indent = 46;
            int keybindsStartLine = 1;
            int gameInfoStartLine = 8;

            Console.SetCursorPosition(indent, keybindsStartLine);
            Console.Write($"Keybinds:");
            Console.SetCursorPosition(indent, keybindsStartLine+1);
            Console.Write($"{gameSettings.MoveUpKey}= Move up\t{gameSettings.MoveDownKey}= Move down");
            Console.SetCursorPosition(indent, keybindsStartLine+2);
            Console.Write($"{gameSettings.MoveLeftKey}= Move left\t{gameSettings.MoveRightKey}= Move right");
            Console.SetCursorPosition(indent, keybindsStartLine+3);
            Console.Write($"{gameSettings.ShootLeftKey}= Shoot left\t{gameSettings.ShootRightKey}= Shoot right");
            Console.SetCursorPosition(indent, keybindsStartLine+4);
            Console.Write($"Other=skip turn\n");

            Console.SetCursorPosition(indent, gameInfoStartLine);
            Console.Write($"Game info:");
            Console.SetCursorPosition(indent, gameInfoStartLine+1);
            Console.Write($"The goal of the game is reaching the bottom unscated.");
            Console.SetCursorPosition(indent, gameInfoStartLine+2);
            Console.Write($"You are ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"P");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" the player.");
            Console.SetCursorPosition(indent, gameInfoStartLine+3);
            Console.Write($"R are the rocks, they are harmless.");
            Console.SetCursorPosition(indent, gameInfoStartLine+4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"M");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" are monsters, they won't harm you unless you run into them.");
            Console.SetCursorPosition(indent, gameInfoStartLine + 5);
            Console.Write($"The most dangerous is ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"X");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($",");
            Console.SetCursorPosition(indent, gameInfoStartLine + 6);
            Console.Write($"as long as you stay below or above him you should be fine...");
        }
    }
}
