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
            Console.Clear();
            ChangeSettingsGameOutput();

            while (true)
            {
                Program.ClearKeyBuffer();
                Program.ClearCurrentConsoleLine();
                ConsoleKey input = Console.ReadKey().Key;

                if (input == ConsoleKey.NumPad1 || input == ConsoleKey.D1)
                {
                    ChangeKeyBinds();
                    Console.Clear();
                    ChangeSettingsGameOutput();
                }
                else if (input == ConsoleKey.NumPad2 || input == ConsoleKey.D2)
                {
                    ChangeDifficulty();
                    Console.Clear();
                    ChangeSettingsGameOutput();
                }
                else if (input == ConsoleKey.NumPad3 || input == ConsoleKey.D3)
                {
                    return;
                }
            }
        }

        private void ChangeDifficulty()
        {
            Console.Clear();
            ChangeDifficultyOutput();

            while (true)
            {
                Program.ClearKeyBuffer();
                Program.ClearCurrentConsoleLine();
                ConsoleKey input = Console.ReadKey().Key;

                if (input == ConsoleKey.NumPad1 || input == ConsoleKey.D1)
                {
                    Difficulty = 12;
                    return;
                }
                else if (input == ConsoleKey.NumPad2 || input == ConsoleKey.D2)
                {
                    Difficulty = 6; //default
                    return;
                }
                else if (input == ConsoleKey.NumPad3 || input == ConsoleKey.D3)
                {
                    Difficulty = 2;
                    return;
                }
            }
        }

        private void ChangeDifficultyOutput()
        {
            Console.WriteLine("Choose difficulty:\n");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium (default)");
            Console.WriteLine("3. Hard");
            Console.WriteLine("\nPress 1, 2 or 3 to continue ");
        }

        private void ChangeSettingsGameOutput()
        {
            Console.Clear();
            Console.WriteLine("Current game settings:\n");
            Console.WriteLine("1. Change keybinds");
            Console.WriteLine("2. Change Difficulty");
            Console.WriteLine("3. Go back to main menu");
            Console.WriteLine("\nPress 1, 2 or 3 to continue ");
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
