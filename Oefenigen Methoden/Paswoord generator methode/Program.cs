using System;

namespace Paswoord_generator_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paswoord generator methode\n");

            int lenght = 5;
            string generatedPassword = PasswordGenerator(lenght);
            Console.WriteLine($"\nPaswoord: {generatedPassword}");
        }

        private static string PasswordGenerator(int lenght)
        {
            Random rand = new Random();
            string returnPassword = "";
            double getalA;

            //loop
            for (int i = 0; i < lenght; i++)
            {
                getalA = rand.Next(48, 109+1);//aantal chars in ascii die we willen gebruiken zijn 61 (109-48)

                //special char filter
                if (getalA >= 84) //skip chars 91 tot 96,  het nummer 84 komt van 91 - 7
                {
                    returnPassword += (char)(getalA + 13);
                }
                else if (getalA >= 58)//skip chars 58 tot 64
                {
                    returnPassword += (char)(getalA + 7);
                }
                else
                {
                    returnPassword += (char)getalA;
                }
                
            }

            return returnPassword;
        }
    }
}
