using System;

namespace Meetlat_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetlat\n");

            Meetlat mijnLat = new Meetlat();
            mijnLat.BeginLengte = 2;
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInVoet} voet.");

            Meetlat mijnTweedeLat = new Meetlat(4);
            Console.WriteLine($"{mijnTweedeLat.LengteInM} meter is {mijnTweedeLat.LengteInVoet} voet.");
        }
    }
}
