using System;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob\n");

            //init vars
            string[] bobAnswers = {
                                    "Sure",
                                    "Whoa, chill out!",
                                    "Calm down, I know what I'm doing!",
                                    "Fine. Be that way!",
                                    "Whatever."
                                  };

            //get input user
            Console.WriteLine("Geef uw convo starter: (eindig met bv: \", bob.\")");
            string convoStarter = Console.ReadLine();
            string last2Char = convoStarter.Substring(Math.Max(0, convoStarter.Length - 2)); //get last 2 char

            Console.WriteLine(last2Char);

            switch (last2Char)
            {
                case "b?":
                    Console.WriteLine(bobAnswers[0]);
                    break;
                case "b!":
                    Console.WriteLine(bobAnswers[1]);
                    break;
                case "?!":
                    Console.WriteLine(bobAnswers[2]);
                    break;
                case "b.":
                    Console.WriteLine(bobAnswers[3]);
                    break;
                default:
                    Console.WriteLine(bobAnswers[4]);
                    break;
            }
        }
    }
}
