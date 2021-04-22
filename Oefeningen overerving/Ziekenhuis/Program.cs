using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ziekenhuis\n");

            Patient josDenBoer = new Patient();
            josDenBoer.Naam = "josDenBoer";
            josDenBoer.UurInZiekehuis = 10;

            VerzekerdePatient koning = new VerzekerdePatient();
            koning.Naam = "koning";
            koning.UurInZiekehuis = 10;

            josDenBoer.ToonInfo();
            koning.ToonInfo();
        }
    }
}
