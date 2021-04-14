using System;
using System.IO;


namespace circel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FreeWheely();
        }
        
        public static void FreeWheely() {
            int[,] my2dArray = new int[20,40];

            double inputValue = 0.0;
            int myX = 0;
            int myY = 0;
            //fill array with 0
            for (int i = 0; i < my2dArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2dArray.GetLength(1); j++) {
                    my2dArray[i, j] = 0;
                }

            }
            
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Console.WriteLine($"breedte: {my2dArray.GetLength(1)} hoogte: {my2dArray.GetLength(0)}");
                    Console.WriteLine("Press ESC to stop drawing");
                    inputValue += 0.1;
                    myX = (int)((Math.Sin(inputValue) * 0.4 + 0.5) * my2dArray.GetLength(0));
                    myY = (int)((Math.Cos(inputValue) * 0.4 + 0.5) * my2dArray.GetLength(1));
                    Console.Write(myX);
                    my2dArray[myX, myY] = 1;
                    //draw array to screen
                    for (int i = 0; i < my2dArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < my2dArray.GetLength(1); j++)
                        {
                            if (my2dArray[i, j] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("0");
                            }
                            else {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("0");
                            }
                            
                        }
                        Console.WriteLine("");

                    }
                    //my2dArray[myX, myY] = 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(10);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
