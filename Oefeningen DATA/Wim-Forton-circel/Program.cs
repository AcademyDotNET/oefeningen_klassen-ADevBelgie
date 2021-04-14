using System;

namespace wim_forton_circel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my2dArray = new int[20, 40];
            double inputValue = 0.0;
            int myX = 0;
            int myY = 0;
            //fill array with 0
            for (int i = 0; i < my2dArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2dArray.GetLength(1); j++)
                {
                    my2dArray[i, j] = 0;
                }
            }
            //fill console with array (all DarkGray 0's)
            for (int i = 0; i < my2dArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2dArray.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("0");                    
                }
                Console.WriteLine("");
            }
            //filling console with circel (1 white zero a time)
            
            while (inputValue < 2*Math.PI)
            {
                //Console.WriteLine($"breedte: {my2dArray.GetLength(1)} hoogte: {my2dArray.GetLength(0)}");
                //Console.WriteLine("Press ESC to stop drawing");
                inputValue += 0.1;
                myX = (int)((Math.Sin(inputValue) * 0.5 + 0.5) * my2dArray.GetLength(0)) + 9;
                myY = (int)((Math.Cos(inputValue) * 0.15 + 0.5) * my2dArray.GetLength(1)) -10;

                //draw 1 position to screen
                Console.SetCursorPosition(myX, myY);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("0");

                //my2dArray[myX, myY] = 0;
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(10);
            }
            Console.SetCursorPosition(0, 20);
            Console.Read();
        }
    }
}
