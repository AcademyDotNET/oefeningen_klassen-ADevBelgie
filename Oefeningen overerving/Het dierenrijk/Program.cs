using System;

namespace Het_dierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het dierenrijk\n");

            Mammal koe = new Mammal();
            Animal amoebe = new Animal();
            Reptile krokodil = new Reptile();

            koe.ToonInfo();
            amoebe.ToonInfo();
            krokodil.ToonInfo();

            Console.ReadLine();
        }
    }
}
