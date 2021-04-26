using System;

namespace Een_eigen_huis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Een eigen huis\n");
            Huis nieuwHuis = new Huis();
            nieuwHuis.kamers.Add(new Badkamer());
            nieuwHuis.kamers.Add(new Gang());
            nieuwHuis.kamers.Add(new Living());

            Console.WriteLine($"De totaalwaarde van het huid is: {nieuwHuis.BerekenPrijs()}");

            Huis oudHuis = new Huis();
            oudHuis.kamers.Add(new Badkamer());
            oudHuis.kamers.Add(new Living(true));

            Console.WriteLine($"De totaalwaarde van het huid is: {oudHuis.BerekenPrijs()}");
        }
    }
}
