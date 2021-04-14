using System;

namespace Euro_naar_dollar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euro naar dollar");

            Console.WriteLine("geef uw getal/ kommagetal in euros");
            double inputGetal = Convert.ToDouble(Console.ReadLine());
            double exchangeRate = 0.85;
            Console.WriteLine($"\nde prijs in dollar is {inputGetal * exchangeRate}$.");
        }
    }
}
