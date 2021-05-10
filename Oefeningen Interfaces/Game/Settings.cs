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
            Difficulty = 6;
            MoveUpKey= ConsoleKey.Z; 
            MoveDownKey= ConsoleKey.S;
            MoveLeftKey = ConsoleKey.Q;
            MoveRightKey = ConsoleKey.D;
            ShootLeftKey = ConsoleKey.A;
            ShootRightKey = ConsoleKey.E;

            PlayerChar = '☺';
            RockDestroyerChar = '☻';
            RockChar = '☼';
            MonsterChar = '♦';
        }
        public char PlayerChar;
        public char RockDestroyerChar;
        public char MonsterChar;
        public char RockChar;
        public int Difficulty { get; set; }
        public string DifficultyString 
        {
            get 
            {
                if (Difficulty == 2)
                {
                    return "Hard";
                }
                else if (Difficulty == 6)
                {
                    return "Medium";
                }
                else
                {
                    return "Easy";
                }
            } 
        }
        public ConsoleKey MoveUpKey { get; set; }
        public ConsoleKey MoveDownKey { get; set; }
        public ConsoleKey MoveLeftKey { get; set; }
        public ConsoleKey MoveRightKey { get; set; }
        public ConsoleKey ShootLeftKey { get; set; }
        public ConsoleKey ShootRightKey { get; set; }

        public void ChangeSettingsGame()
        {
            string[] menuOptions =
            {
                "Change keybinds",
                "Change Difficulty",
                "Return to main menu"
            };
            Menu settingsMenu = new Menu(menuOptions, "Settings");
            int keuze;
            while (true)
            {
                keuze = settingsMenu.Start();
                switch (keuze)
                {
                    case 1:
                        ChangeKeyBinds();
                        Console.Clear();
                        settingsMenu.MenuOutput();
                        break;
                    case 2:
                        ChangeDifficulty();
                        Console.Clear();
                        settingsMenu.MenuOutput();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            } 
        }

        private void ChangeDifficulty()
        {
            string[] menuOptions =
            {
                "Easy",
                "Medium (default)",
                "Hard"
            };
            Menu changeDifficultyMenu = new Menu(menuOptions, "Difficulty");
            int keuze;
            while (true)
            {
                keuze = changeDifficultyMenu.Start();
                switch (keuze)
                {
                    case 1:
                        Difficulty = 12;
                        return;
                    case 2:
                        Difficulty = 6; //default
                        return;
                    case 3:
                        Difficulty = 2;
                        return;
                    default:
                        break;
                }
            }
        }
        private void ChangeKeyBinds()
        {
            Console.Clear();
            Console.WriteLine(this);
            ConsoleKey tempMoveUpKey = MoveUpKey;
            MoveUpKey = ConsoleKey.Escape;
            ConsoleKey tempMoveDownKey = MoveDownKey;
            MoveDownKey = ConsoleKey.Escape;
            ConsoleKey tempMoveLeftKey = MoveLeftKey;
            MoveLeftKey = ConsoleKey.Escape;
            ConsoleKey tempMoveRightKey = MoveRightKey;
            MoveRightKey = ConsoleKey.Escape;
            ConsoleKey tempShootLeftKey = ShootLeftKey;
            ShootLeftKey = ConsoleKey.Escape;
            ConsoleKey tempShootRightKey = ShootRightKey;
            ShootRightKey = ConsoleKey.Escape;

            Console.WriteLine("\n\nPress enter for default key shown above");  
            MoveUpKey = Change1Key("move up key", tempMoveUpKey);
            MoveDownKey = Change1Key("move down key", tempMoveDownKey);
            MoveLeftKey = Change1Key("move left key", tempMoveLeftKey);
            MoveRightKey = Change1Key("move right key", tempMoveRightKey);
            ShootLeftKey = Change1Key("shoot left key",  tempShootLeftKey);
            ShootRightKey = Change1Key("shoot right key", tempShootRightKey);
        }
        private ConsoleKey Change1Key(string keyInfo, ConsoleKey defaultKey)
        {
            Console.WriteLine($"\nChoose which key to bind for the \"{keyInfo}\": ");

            ConsoleKey returnKey = Console.ReadKey().Key;
            
            while (returnKey != defaultKey && (returnKey == MoveUpKey || returnKey == MoveDownKey || returnKey == MoveLeftKey || returnKey == MoveRightKey || returnKey == ShootLeftKey || returnKey == ShootRightKey))
            {
                Program.ClearCurrentConsoleLine();
                Console.WriteLine($"{(returnKey == ConsoleKey.Escape?"T":"")}That key is already taken for an action ");//when pressing
                returnKey = Console.ReadKey().Key;
            }
            if (returnKey == ConsoleKey.Enter)
            {
                returnKey = defaultKey;
            }

            return returnKey;
        }

        public override string ToString()
        {
            string totalString = $"MoveUpKey = {MoveUpKey}\n";
            totalString += $"MoveDownKey = {MoveDownKey}\n";
            totalString += $"MoveLeftKey = {MoveLeftKey}\n";
            totalString += $"MoveRightKey = {MoveRightKey}\n";
            totalString += $"ShootLeftKey = {ShootLeftKey}\n";
            totalString += $"ShootRightKey = {ShootRightKey}";
            return totalString;
        }
    }
}
