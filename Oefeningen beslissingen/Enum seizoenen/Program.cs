using System;

namespace Enum_seizoenen
{
    class Program
    {
        enum Seizoenen { Winter, Lente, Zomer, Herfst, None }
        static void Main(string[] args)
        {
            Console.WriteLine("Enum seizoenen\n");

            //intit vars
            Seizoenen inputMaandSeizoen;

            //input user
            Console.WriteLine("Geef een maand nummer");
            int inputMaand = Convert.ToInt32(Console.ReadLine());

            switch(inputMaand)
            {
                case 1:
                case 2:
                case 3:
                    inputMaandSeizoen = Seizoenen.Winter;
                    break;
                case 4:
                case 5:
                case 6:
                    inputMaandSeizoen = Seizoenen.Lente;
                    break;
                case 7:
                case 8:
                case 9:
                    inputMaandSeizoen = Seizoenen.Zomer;
                    break;
                case 10:
                case 11:
                case 12:
                    inputMaandSeizoen = Seizoenen.Herfst;
                    break;
                default:
                    inputMaandSeizoen = Seizoenen.None;
                    Console.WriteLine("U heeft een fout nummer ingegeven");
                    break;
            }

            if(inputMaandSeizoen == Seizoenen.Winter || inputMaandSeizoen == Seizoenen.Herfst)
            {
                Console.WriteLine("Het is een koude maand in het seizoen ");
            }
            else if (inputMaandSeizoen == Seizoenen.Zomer || inputMaandSeizoen == Seizoenen.Lente)
            {
                Console.WriteLine("Het is een warme maand");
            }

            Console.ReadLine();
        }
    }
}
