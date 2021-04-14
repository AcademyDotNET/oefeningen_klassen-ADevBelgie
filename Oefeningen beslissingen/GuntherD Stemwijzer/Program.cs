using System;

namespace GuntherD_Stemwijzer
{
    class Program
    {
        enum Antwoord { Nee = 'N', Ja = 'J'}
        static void Main(string[] args)
        {
            
            //De oefening had veel makkelijker en beter gemaakt kunnen worden zonder enums en met een switch
            
            Console.WriteLine("GuntherD Stemwijzer\n");

            //init vars
            Antwoord userInput;
            const string vraag1 = "werk je veel? ";

            const string vraagJ = "Koop je soms bruin brood? ";
            const string vraagJJ = "ben je een seut? ";
            const string vraagJJN = "Heb je vrienden? ";
            const string vraagJJNJ = "Staat jouw wagen op naam van jouw ouders? ";

            const string vraagN = "Eet je vaak Quinoa? ";
            const string vraagNN = "Krijg je vaak de schuld van alles? ";
            const string vraagNNN = "Geloof je nog in sinterklaas? ";

            //input from user
            Console.WriteLine($"{vraag1}");
            userInput = (Antwoord)Convert.ToChar(Console.ReadLine());

            if (userInput == (Antwoord)'J')
            {
                Console.WriteLine($"{vraagJ}");
                userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                if (userInput == Antwoord.Ja)
                {
                    Console.WriteLine($"{vraagJJ}");
                    userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                    if (userInput == (Antwoord)'N')
                    {
                        Console.WriteLine($"{vraagJJN}");
                        userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                        if (userInput == (Antwoord)'J')
                        {
                            Console.WriteLine($"{vraagJJNJ}");
                            userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                            if (userInput == (Antwoord)'J')
                            {
                                Console.WriteLine($"open vld");
                            }
                            else if (userInput == (Antwoord)'N')
                            {
                                Console.WriteLine($"Blanco");
                            }
                        }
                        else if (userInput == (Antwoord)'N')
                        {
                            Console.WriteLine($"NVA");
                        }
                    }
                    else if (userInput == (Antwoord)'J')
                    {
                        Console.WriteLine($"CD&V");
                    }
                }
                else if (userInput == (Antwoord)'N')
                {
                    Console.WriteLine($"Vlaams Belang");
                }
                else if (userInput == (Antwoord)'N')
                {
                    Console.WriteLine($"{vraagN}");
                    userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                    if (userInput == (Antwoord)'J')
                    {
                        Console.WriteLine($"Groen");
                    }
                    else if (userInput == (Antwoord)'N')
                    {
                        Console.WriteLine($"{vraagNN}");
                        userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                        if (userInput == (Antwoord)'N')
                        {
                            Console.WriteLine($"{vraagNNN}");
                            userInput = (Antwoord)Convert.ToChar(Console.ReadLine());
                            if (userInput == (Antwoord)'N')
                            {
                                Console.WriteLine($"Blanco");
                            }
                            else if (userInput == (Antwoord)'J')
                            {
                                Console.WriteLine($"pvda");
                            }
                        }
                        else if (userInput == (Antwoord)'J')
                        {
                            Console.WriteLine($"spa");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}