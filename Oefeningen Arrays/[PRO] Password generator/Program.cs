using System;

namespace _PRO__Password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[PRO] Password generator\n");

            //input user
            Console.WriteLine("\nFamilienaam:");
            string familienaam = Console.ReadLine();

            Console.WriteLine("telefoonnummer :");
            string telefoonnummer = Console.ReadLine();

            Console.WriteLine("postcode  :");
            string postcode = Console.ReadLine();

            string generatedPassword = generatePassword(familienaam, telefoonnummer, postcode);
            Console.WriteLine($"paswoord  :{generatedPassword}");
        }

        private static string generatePassword(string familienaam, string telefoonnummer, string postcode)
        {
            //part1 = first 2 char lastname
            string part1 = familienaam.Substring(0, 2);

            //part2 = first 2 char lastname reversed
            string part2 = "";
            part2 += familienaam[1];
            part2 += familienaam[0];

            //part3 = zonenumber telephone
            string part3 = telefoonnummer.Substring(1, 2);

            //part4 = first number postal code ^2
            string part4 = "";
            part4 += postcode[0];
            double tempPart4D = Convert.ToDouble(part4);
            part4 = Convert.ToString(Math.Pow(tempPart4D, 2));

            //init password
            string password= part1 + part2 + part3 + part4;

            return password;
        }
    }
}
