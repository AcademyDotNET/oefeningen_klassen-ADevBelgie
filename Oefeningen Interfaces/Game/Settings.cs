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

        public void ChangeSettingsGame()
        {
            Console.Clear();
            
            bool returnToMainMenu = false;
            while (!returnToMainMenu)
            {
                ChangeSettingsGameOutput();

                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
                {
                    ChangeKeyBinds();
                }
                else if (input.Key == ConsoleKey.NumPad2 || input.Key == ConsoleKey.D2)
                {
                    ChangeDifficulty();
                }
                else if (input.Key == ConsoleKey.NumPad3 || input.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    returnToMainMenu = true;
                }
            }
        }

        private static void ChangeDifficulty()
        {
        }

        private void ChangeSettingsGameOutput()
        {
            Console.Clear();
            Console.WriteLine("Current game settings:\n");
            Console.WriteLine("1. Change keybinds");
            Console.WriteLine("2. Change Difficulty");
            Console.WriteLine("3. Go back to main menu");
        }
        private void ChangeKeyBinds()
        {
            Console.Clear();
            Console.WriteLine(this);
            Console.WriteLine("\n\nPress enter for default key shown above");  
            MoveUpKey = Change1Key("move up key", MoveUpKey);
            MoveDownKey = Change1Key("move down key", MoveDownKey);
            MoveLeftKey = Change1Key("move left key", MoveLeftKey);
            MoveRightKey = Change1Key("move right key", MoveRightKey);
            ShootLeftKey = Change1Key("shoot left key",  ShootLeftKey);
            ShootRightKey = Change1Key("shoot right key", ShootRightKey);
        }
        private ConsoleKey Change1Key(string keyInfo, ConsoleKey defaultKey)
        {
            Console.Write($"\nChoose which key to bind for the \"{keyInfo}\": ");
            ConsoleKey returnKey = Console.ReadKey().Key;
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
