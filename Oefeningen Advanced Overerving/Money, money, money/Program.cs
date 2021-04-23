using System;

namespace Money__money__money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Money, money, money\n");

            BankRekening normaleRekening = new BankRekening();
            SpaarRekening spaarRekening = new SpaarRekening();
            ProRekening proRekening = new ProRekening();

            Console.WriteLine("Saldo\'s:");
            Console.WriteLine(normaleRekening.Saldo);
            Console.WriteLine(spaarRekening.Saldo);
            Console.WriteLine(proRekening.Saldo);

            Console.WriteLine("Rente\'s:");
            Console.WriteLine(normaleRekening.BerekenRente());
            Console.WriteLine(spaarRekening.BerekenRente());
            Console.WriteLine(proRekening.BerekenRente());

            normaleRekening.HaalGeldAf(1000);
            normaleRekening.VoegGeldToe(1000);
            spaarRekening.VoegGeldToe(1000);
            proRekening.VoegGeldToe(1000);

            Console.WriteLine("Rente\'s met 1000 Euro:");
            Console.WriteLine(normaleRekening.BerekenRente());
            Console.WriteLine(spaarRekening.BerekenRente());
            Console.WriteLine(proRekening.BerekenRente());

            Console.WriteLine("Rente proRekening met 3000 Euro:");
            proRekening.VoegGeldToe(2000);
            Console.WriteLine(proRekening.BerekenRente());
        }
    }
}
