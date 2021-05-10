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
            Keuzes = keuzes;
        }
        private string[] Keuzes { get; set; }

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
                else if (input == ConsoleKey.NumPad3 || input == ConsoleKey.D3)
                {
                    return 3;
                }
                else if (input == ConsoleKey.NumPad4 || input == ConsoleKey.D4)
                {
                    return 4;
                }
            }
        }
        private void MenuOutput()
        {
            //Writes to console what options the user can choose from
            Console.WriteLine("Menu\n");

            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Keuzes[i]}{(i==Keuzes.Length-1?"\n":"")}");
            }
            Console.Write("Press");
            for (int i = 0; i < Keuzes.Length; i++)
            {
                Console.Write($"{(i == Keuzes.Length - 1 ? "\n" : "")}");
            }
            Console.WriteLine(" to continue ");
        }
    }
}
