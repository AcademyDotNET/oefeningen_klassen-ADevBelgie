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
            IUserOutput output = new UserOutput();
            //this info is diplayed to the right of the game while the game is being played
            int indent = 46;
            int GameDifficultyStartLine = 0;
            int keybindsStartLine = 2;
            int gameInfoStartLine = 9;
            
            output.SetCursorPosition(indent, GameDifficultyStartLine);
            output.WriteLine($"Difficulty: {gameSettings.DifficultyString}");
            output.SetCursorPosition(indent, keybindsStartLine);
            output.Write($"Keybinds:");
            output.SetCursorPosition(indent, keybindsStartLine+1);
            output.Write($"{gameSettings.MoveUpKey}= Move up\t{gameSettings.MoveDownKey}= Move down");
            output.SetCursorPosition(indent, keybindsStartLine+2);
            output.Write($"{gameSettings.MoveLeftKey}= Move left\t{gameSettings.MoveRightKey}= Move right");
            output.SetCursorPosition(indent, keybindsStartLine+3);
            output.Write($"{gameSettings.ShootLeftKey}= Shoot left\t{gameSettings.ShootRightKey}= Shoot right");
            output.SetCursorPosition(indent, keybindsStartLine+4);
            output.Write($"ESC= Exit game\tOther= Skip turn");

            output.SetCursorPosition(indent, gameInfoStartLine);
            output.Write($"Game info:");
            output.SetCursorPosition(indent, gameInfoStartLine+1);
            output.Write($"The goal of the game is reaching the bottom unscated.");
            output.SetCursorPosition(indent, gameInfoStartLine+2);
            output.Write($"You are ");
            output.ForegroundColor = ConsoleColor.Green;
            output.Write($"{gameSettings.PlayerChar}");
            output.ForegroundColor = ConsoleColor.Gray;
            output.Write($" the player.");
            output.SetCursorPosition(indent, gameInfoStartLine+3);
            output.Write($"{gameSettings.RockChar} are the rocks, they are harmless.");
            output.SetCursorPosition(indent, gameInfoStartLine+4);
            output.ForegroundColor = ConsoleColor.Red;
            output.Write($"{gameSettings.MonsterChar}");
            output.ForegroundColor = ConsoleColor.Gray;
            output.Write($" are monsters, they won't harm you unless you run into them.");
            output.SetCursorPosition(indent, gameInfoStartLine + 5);
            output.Write($"The most dangerous is ");
            output.ForegroundColor = ConsoleColor.Magenta;
            output.Write($"{gameSettings.RockDestroyerChar}");
            output.ForegroundColor = ConsoleColor.Gray;
            output.Write($",");
            output.SetCursorPosition(indent, gameInfoStartLine + 6);
            output.Write($"as long as you stay below or above him you should be fine...");
        }
    }
}
