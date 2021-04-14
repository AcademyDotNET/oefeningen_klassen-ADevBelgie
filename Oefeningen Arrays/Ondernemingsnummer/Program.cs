using System;

namespace Ondernemingsnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ondernemingsnummer\n");

            //init
            string ondernemingsnummer = "BE 0xxx.xxx.xxx"; //niet valide

            //calc
            bool valid = CheckValidOndernemingsnummer(ondernemingsnummer);

            //output
            Console.WriteLine($"{ondernemingsnummer} is {(valid? "": "g")}een ondernemingsnummer");

            Console.WriteLine("geef een ondernemingsnummer");
            ondernemingsnummer = Console.ReadLine();

            valid = CheckValidOndernemingsnummer(ondernemingsnummer);
            Console.WriteLine($"{ondernemingsnummer} is {(valid ? "" : "g")}een ondernemingsnummer");
        }

        private static bool CheckValidOndernemingsnummer(string ondernemingsnummer)
        {
            //lenght check
            if (ondernemingsnummer.Length != 15)
            {
                Console.WriteLine("lenght check" + ondernemingsnummer.Length);
                return false;
            }
            //1st check BE -- 0xxx.xxx.xxx waarbij BE de landcode is die standaard gevolgd wordt door een spatie en dan een 0.
            if (ondernemingsnummer.Substring(0,4) != "BE 0")
            {
                Console.WriteLine("1st check " + ondernemingsnummer.Substring(0, 3));
                return false;
            }

            //2de check
            string substringTweedeCheck = "";
            int tempInt;
            //vullen met eerste 7 cijfers
            substringTweedeCheck += ondernemingsnummer.Substring(4, 3);
            substringTweedeCheck += ondernemingsnummer.Substring(8, 3);
            substringTweedeCheck += ondernemingsnummer[12];


            if (!Int32.TryParse(substringTweedeCheck, out tempInt))
            {
                Console.WriteLine("2de check deel 1 ");
                return false;
            }
            tempInt = Convert.ToInt32(substringTweedeCheck)/(int)97;
            string tempString = Convert.ToString(tempInt);
            tempString = tempString.Substring((tempString.Length - 2), tempString.Length);
            tempInt = Convert.ToInt32(tempString);

            int restTempInt = 97 - (Convert.ToInt32(substringTweedeCheck) % 97);

            if (tempInt != restTempInt)
            {
                Console.WriteLine("2de check deel 2 ");
                return false;
            }

            return true;
        }
    }
}
