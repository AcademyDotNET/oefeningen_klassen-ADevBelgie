using System;

namespace Vraag_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vraag Array\n");

            //init vars
            string[] vragenArray = {
                                        "Wat is het eerste wat je zou invoeren als je baas van de wereld zou zijn?",
                                        "Als je een eiland zou hebben, wat is het eerste wat je zou bouwen?",
                                        "Als je naar een onbewoond eiland zou gaan voor de rest van je leven en je mocht maar 1 item meenemen, wat zou dat zijn?",
                                        "Wat is jouw geheime superkracht?",
                                        "Wat is het leukste cadeau dat je ooit hebt gekregen?",
                                        "Noem één ding dat mensen waarschijnlijk nog niet wisten van jou?"
                                   };

            //user input
            int[] antwoordenArray = GetAnswersUser(vragenArray);

            //output
            OutputAnswersUser(vragenArray, antwoordenArray);

            Console.ReadLine();
        }

        private static int[] GetAnswersUser(string[] vragenArray)
        {
            int[] antwoordenArray = new int [6];

            //get user input for all questions
            for (int i = 0; i < vragenArray.Length; i++)
            {
                Console.WriteLine(vragenArray[i]);
                antwoordenArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return antwoordenArray;
        }

        private static void OutputAnswersUser(string[] vragenArray, int[] antwoordenArray)
        {
            Console.WriteLine("");
            for (int i = 0; i < vragenArray.Length; i++)
            {
                Console.Write(vragenArray[i]);
                Console.WriteLine($" {antwoordenArray[i]}");
            }
        }
    }
}
