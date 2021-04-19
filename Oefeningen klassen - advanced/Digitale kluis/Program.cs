using System;

namespace Digitale_kluis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DigitaleKluis\n");

            DigitaleKluis eersteKluis = new DigitaleKluis(56);
            eersteKluis.TryCode(55);
            eersteKluis.TryCode(56);
            Console.WriteLine(eersteKluis.Code);
            eersteKluis.CanShowCode = true;
            Console.WriteLine(eersteKluis.Code);
        }
    }
}
