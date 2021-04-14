using System;

namespace Meetlat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetlat\n");
            //Test github

            Meetlat mijnLat = new Meetlat();
            mijnLat.BeginLengte = 2;
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInVoet} voet.");
        }
    }
}
