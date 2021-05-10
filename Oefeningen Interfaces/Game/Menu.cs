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
            Console.Clear();
            MenuOutput();

            while (true)
            {
                Program.ClearKeyBuffer();
                Program.ClearCurrentConsoleLine();
                ConsoleKey input = Console.ReadKey().Key;

                if (input == ConsoleKey.NumPad1 || input == ConsoleKey.D1)
                {
                    return 1;
                }
                else if (input == ConsoleKey.NumPad2 || input == ConsoleKey.D2)
                {
                    return 2;
                }
                else if (Keuzes.Length >= 3 && (input == ConsoleKey.NumPad3 || input == ConsoleKey.D3) )
                {
                    return 3;
                }
                else if (Keuzes.Length >= 4 && (input == ConsoleKey.NumPad4 || input == ConsoleKey.D4) )
                {
                    return 4;
                }
                else if (Keuzes.Length >= 5 && (input == ConsoleKey.NumPad5 || input == ConsoleKey.D5) )
                {
                    return 5;
                }
                else if (Keuzes.Length >= 6 && (input == ConsoleKey.NumPad6 || input == ConsoleKey.D6) )
                {
                    return 6;
                }
                else if (Keuzes.Length >= 7 && (input == ConsoleKey.NumPad7 || input == ConsoleKey.D7) )
                {
                    return 7;
                }
                else if (Keuzes.Length >= 8 && (input == ConsoleKey.NumPad8 || input == ConsoleKey.D8) )
                {
                    return 8;
                }
                else if (Keuzes.Length >= 9 && (input == ConsoleKey.NumPad9 || input == ConsoleKey.D9) )
                {
                    return 9;
                }
            }
        }
        public void MenuOutput()
        {
            //Writes to console what options the user can choose from
            Console.WriteLine($"{MenuName}{(MenuName != ""? " " :"")}Menu\n");

            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Keuzes[i]}{(i==Keuzes.Length-1?"\n":"")}");
            }
            Console.Write("Press");
            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.Write($"{(i == Keuzes.Length - 1 ? "or" : "")} {i+1}{(i < Keuzes.Length - 2 ? "," : " ")}");
            }
            Console.WriteLine("to continue ");
        }
    }
}
