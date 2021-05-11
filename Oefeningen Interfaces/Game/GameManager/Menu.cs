using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Menu
    {
        public Menu(string[] keuzes)
        {
            Keuzes = keuzes;//maximaal 9 keuzes
            MenuName = "";
        }
        public Menu(string[] keuzes, string menuName)
        {
            Keuzes = keuzes;//maximaal 9 keuzes
            MenuName = menuName;
        }
        private string[] Keuzes { get; set; }
        public string MenuName { get; set; }

        public int Start()
        {
            IUserOutput output = new UserOutput();
            IUserInput input = new UserInput();
            output.Clear();
            MenuOutput();

            while (true)
            {
                input.GetKey();

                if (input.UserInputKey == ConsoleKey.NumPad1 || input.UserInputKey == ConsoleKey.D1)
                {
                    return 1;
                }
                else if (input.UserInputKey == ConsoleKey.NumPad2 || input.UserInputKey == ConsoleKey.D2)
                {
                    return 2;
                }
                else if (Keuzes.Length >= 3 && (input.UserInputKey == ConsoleKey.NumPad3 || input.UserInputKey == ConsoleKey.D3) )
                {
                    return 3;
                }
                else if (Keuzes.Length >= 4 && (input.UserInputKey == ConsoleKey.NumPad4 || input.UserInputKey == ConsoleKey.D4) )
                {
                    return 4;
                }
                else if (Keuzes.Length >= 5 && (input.UserInputKey == ConsoleKey.NumPad5 || input.UserInputKey == ConsoleKey.D5) )
                {
                    return 5;
                }
                else if (Keuzes.Length >= 6 && (input.UserInputKey == ConsoleKey.NumPad6 || input.UserInputKey == ConsoleKey.D6) )
                {
                    return 6;
                }
                else if (Keuzes.Length >= 7 && (input.UserInputKey == ConsoleKey.NumPad7 || input.UserInputKey == ConsoleKey.D7) )
                {
                    return 7;
                }
                else if (Keuzes.Length >= 8 && (input.UserInputKey == ConsoleKey.NumPad8 || input.UserInputKey == ConsoleKey.D8) )
                {
                    return 8;
                }
                else if (Keuzes.Length >= 9 && (input.UserInputKey == ConsoleKey.NumPad9 || input.UserInputKey == ConsoleKey.D9) )
                {
                    return 9;
                }
            }
        }
        public void MenuOutput()
        {
            IUserOutput output = new UserOutput();

            //Writes to console what options the user can choose from
            output.WriteLine($"{MenuName}{(MenuName != ""? " " :"")}Menu\n");

            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Keuzes[i]}{(i==Keuzes.Length-1?"\n":"")}");
            }
            output.Write("Press");
            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.Write($"{(i == Keuzes.Length - 1 ? "or" : "")} {i+1}{(i < Keuzes.Length - 2 ? "," : " ")}");
            }
            output.WriteLine("to continue ");
        }
    }
}
