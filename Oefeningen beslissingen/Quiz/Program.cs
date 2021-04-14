using System;
using System.Threading;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz\n");

            //init vars
            int correctAnswers = 0;

            //get input user for Q1
            Console.WriteLine("\nhoeveel armen heeft een mens");
            Console.WriteLine("a: 1\nb: 2\nc: 3\nd: 4");
            char inputUser = Convert.ToChar(Console.ReadLine());

            switch(inputUser)
            {
                case 'b':
                    Console.WriteLine("Q1 heeft u juist");
                    correctAnswers++;
                    break;
                default:
                    Console.WriteLine("Q1 heeft u fout");
                    break;
            }
            Console.ReadLine();
            Console.Clear();

            //get input user for Q2
            Console.WriteLine("\nhoeveel darmen heeft een mens");
            Console.WriteLine("a: 1\nb: 2\nc: 3\nd: 4");
            inputUser = Convert.ToChar(Console.ReadLine());

            switch (inputUser)
            {
                case 'a':
                    Console.WriteLine("Q2 heeft u juist");
                    correctAnswers++;
                    break;
                default:
                    Console.WriteLine("Q2 heeft u fout");
                    break;
            }
            Console.ReadLine();
            Console.Clear();

            //get input user for Q3
            Console.WriteLine("\nhoeveel benen heeft een mens?");
            Console.WriteLine("a: 1\nb: 2\nc: 3\nd: 4");
            inputUser = Convert.ToChar(Console.ReadLine());

            switch (inputUser)
            {
                case 'b':
                    Console.WriteLine("Q3 heeft u juist");
                    correctAnswers++;
                    break;
                default:
                    Console.WriteLine("Q3 heeft u fout");
                    break;
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"\nU heeft een totaal score van: {(correctAnswers * 2) - (3 - correctAnswers)}");
            Console.ReadLine();
        }
    }
}
