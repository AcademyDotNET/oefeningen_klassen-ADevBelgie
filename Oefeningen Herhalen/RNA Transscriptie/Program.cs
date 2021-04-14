using System;

namespace RNA_Transscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RNA Transscriptie\n");

            //init vars
            string dnaString;
            string rnaString = "";

            //user input
            Console.WriteLine("Geef uw dna string die u wilt omzetten naar RNA");
            dnaString = Console.ReadLine();

            /*
            //    G wordt C
            //    C wordt G
            //    T wordt A
            //    A wordt U
            */
            //calculating output
            for (int i = 0; i < dnaString.Length; i++) 
            {
                if (dnaString[i] == 'G')
                {
                    rnaString += 'C';
                }
                else if (dnaString[i] == 'C')
                {
                    rnaString += 'G';
                }
                else if (dnaString[i] == 'T')
                {
                    rnaString += 'A';
                }
                else if (dnaString[i] == 'A')
                {
                    rnaString += 'U';
                }
                else 
                {
                    rnaString += dnaString[i];
                }
            }

            Console.WriteLine(rnaString);
            Console.ReadLine();
        }
    }
}
