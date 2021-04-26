using System;

namespace Moederbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moederbord\n");

            Moederbord Z390E_GAMING = new Moederbord("Z390E_GAMING");
            Z390E_GAMING.TestMoederbord();
            Z390E_GAMING.MoederbordBIOS = new BIOS("2.8");
            Z390E_GAMING.MoederbordCPU = new CPU("IntelCorei9_9900K");
            Z390E_GAMING.moederbordMemorySocket.Add("DDR9 MEGARAM");
            Z390E_GAMING.moederbordMemorySocket.Add("DDR9 MEGARAM");

            Z390E_GAMING.TestMoederbord();
        }
    }
}
