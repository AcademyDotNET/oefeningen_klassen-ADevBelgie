using System;

namespace ASCII_Art_And_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeColorName();
            Console.WriteLine(@"   _____            __   .__                    ");

            ChangeColorName();
            Console.Write(@"  /  _  \ _______ _/  |_ |  |__   __ __ ");
            ChangeColorLetter();
            Console.WriteLine(@"_______ ");

            ChangeColorName();
            Console.Write(@" /  /_\  \\_  __ \\   __\|  |  \ |  |  \");
            ChangeColorLetter();
            Console.WriteLine(@"\_  __ \");

            ChangeColorName();
            Console.Write(@"/    |    \|  | \/ |  |  |   Y  \|  |  / ");
            ChangeColorLetter();
            Console.WriteLine(@"|  | \/");

            ChangeColorName();
            Console.Write(@"\____|__  /|__|    |__|  |___|  /|____/  ");
            ChangeColorLetter();
            Console.WriteLine(@"|__|   ");

            ChangeColorName();
            Console.Write(@"        \/                    \/                ");

            ChangeColorEnd();
        }

        static void ChangeColorName() {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void ChangeColorLetter()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void ChangeColorEnd()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
