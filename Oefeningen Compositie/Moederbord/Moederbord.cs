using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Moederbord
    {
        public Moederbord()
        {

        }
        public Moederbord(string naam)
        {
            Naam = naam;
        }
        public string Naam { get; set; }
        public BIOS MoederbordBIOS { get; set; }
        public CPU MoederbordCPU { get; set; }

        public List<string> moederbordMemorySocket = new List<string>();

        public void TestMoederbord()
        {
            Console.WriteLine("Dit moederbordt heeft nog geen:");
            if (Naam == null)
            {
                Console.WriteLine("Naam");
            }
            if (MoederbordBIOS == null)
            {
                Console.WriteLine("MoederbordBIOS");
            }
            if (MoederbordCPU == null)
            {
                Console.WriteLine("MoederbordCPU");
            }
            if (moederbordMemorySocket.Count == 0)
            {
                Console.WriteLine("Ram");
            }
        }
    }
}
