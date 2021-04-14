using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BeerSong\n");

            //init vars
            int aantalBeer = 99;
            int beerDelay = 1;

            //loop
            while (true)
            {
                for (int i = 0; i < aantalBeer - 2; i++)
                {
                    Console.WriteLine($"{aantalBeer - i} bottles of beer on the wall, {aantalBeer - i} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {aantalBeer - i - 1} bottles of beer on the wall.");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(beerDelay);
                }
                Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                Console.WriteLine($"Take it down and pass it around, no more bottles of beer on the wall.");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(beerDelay);
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(beerDelay);
            }
            
        }
    }
}
