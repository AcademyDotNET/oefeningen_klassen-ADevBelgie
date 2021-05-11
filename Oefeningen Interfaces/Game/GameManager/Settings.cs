﻿using System;
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
            RockDestroyerChar = 'X';
            RockChar = '҈';
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
            IUserOutput output = new UserOutput();

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
                        output.Clear();
                        settingsMenu.MenuOutput();
                        break;
                    case 2:
                        ChangeDifficulty();
                        output.Clear();
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
                "Hard",
                "Return"
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
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        private void ChangeKeyBinds()
        {
            //init interfaces
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            output.Clear();
            output.ForegroundColor = ConsoleColor.Yellow;
            output.WriteLine(this.ToString());
            output.ForegroundColor = ConsoleColor.Gray;

            ConsoleKey tempMoveUpKey = MoveUpKey;
            MoveUpKey = input.Backspace;
            ConsoleKey tempMoveDownKey = MoveDownKey;
            MoveDownKey = input.Backspace;
            ConsoleKey tempMoveLeftKey = MoveLeftKey;
            MoveLeftKey = input.Backspace;
            ConsoleKey tempMoveRightKey = MoveRightKey;
            MoveRightKey = input.Backspace;
            ConsoleKey tempShootLeftKey = ShootLeftKey;
            ShootLeftKey = input.Backspace;
            ConsoleKey tempShootRightKey = ShootRightKey;
            ShootRightKey = input.Backspace;

            output.WriteLine("\n\nPress Enter/Esc for default key shown above");  
            MoveUpKey = Change1Key("move up key", tempMoveUpKey);
            MoveDownKey = Change1Key("move down key", tempMoveDownKey);
            MoveLeftKey = Change1Key("move left key", tempMoveLeftKey);
            MoveRightKey = Change1Key("move right key", tempMoveRightKey);
            ShootLeftKey = Change1Key("shoot left key",  tempShootLeftKey);
            ShootRightKey = Change1Key("shoot right key", tempShootRightKey);
        }
        private ConsoleKey Change1Key(string keyInfo, ConsoleKey defaultKey)
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();

            output.WriteLine($"\nChoose which key to bind for the \"{keyInfo}\": ");

            input.GetKey();


            while (input.UserInputKey != defaultKey && (input.UserInputKey == MoveUpKey || input.UserInputKey == MoveDownKey || input.UserInputKey == MoveLeftKey || input.UserInputKey == MoveRightKey || input.UserInputKey == ShootLeftKey || input.UserInputKey == ShootRightKey))
            {
                input.GetKey();
            }
            if (input.UserInputKey == input.Enter || input.UserInputKey == input.Escape)
            {
                input.UserInputKey = defaultKey;
            }

            return input.UserInputKey;
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
