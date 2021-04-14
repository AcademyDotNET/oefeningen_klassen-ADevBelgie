using System;

namespace simplemaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //runSimpleMaths();
            //runGemiddelde();
            //runEuroDollar();
            //runConsoleClear();
            runKillDeathRatio();
            //runSpace();
            //floatTest();
        }
        public static void runSimpleMaths()
        {
            int myInt1 = -1 + 4 * 6;
            int myInt2 = (35 + 5) % 7;
            int myInt3 = 14 + -4 * 6 / 11;
            int myInt4 = 2 + 15 / 6 * 1 - 7 % 2;

            double myDouble1 = -1 + 4 * 6.0;
            double myDouble2 = (35 + 5) % 7.0;
            double myDouble3 = 14 + -4 * 6 / 11.0;
            double myDouble4 = 2 + 15.0 / 6 * 1 - 7 % 2;

            Console.WriteLine(myInt1);
            Console.WriteLine(myDouble1);
            Console.WriteLine(myInt2);
            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt3);
            Console.WriteLine(myDouble3);
            Console.WriteLine(myInt4);
            Console.WriteLine(myDouble4);
        }

        public static void runGemiddelde()
        {
            int september = 160;
            int oktober = 143;
            int november = 251;
            double myGemiddelde = (double)(september + oktober + november) / 3;
            Console.WriteLine(myGemiddelde);
        }

        public static void runEuroDollar()
        {
            Console.WriteLine("Geef euro in");
            //int intTemp = Convert.ToInt32(Console.ReadLine());

            double myEuro = Convert.ToDouble(Console.ReadLine());
            double myDollar = myEuro * 0.95;
            Console.WriteLine($"Dat is dan {myDollar} dollar");
        }
        public static void runConsoleClear()
        {
            Console.WriteLine("give a startnumber");

            int myNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 11; i++)
            {
                Console.Clear();
                int myResult = myNumber * i;
                Console.WriteLine($"{i} X {myNumber} = {myResult} dollar");
                Console.WriteLine("press any key for next");
                Console.ReadLine();
                
            }
        }
        public static void runKillDeathRatio()
        {
            Console.WriteLine("what's your kill number?");
            double myKillNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what's your death number?");
            double myDeathNumber = Convert.ToDouble(Console.ReadLine());

            double myRatio = myKillNumber / myDeathNumber;
            Console.WriteLine($"your ratio is {myRatio}");
        }

        public static void runSpace() 
        {

            Console.WriteLine("geef uw gewicht");
            double myWeight = Convert.ToDouble(Console.ReadLine());
            string[] planeetNamen = {"mercurius", "venus", "aarde", "mars", "jupiter", "saturnus", "uranus", "neptunus", "pluto"};
            double[] planeetWeights = { 0.38, 0.91, 1.0, 0.38, 2.34, 1.06, 0.92, 1.19, 0.06 };
            int index = 0;
            foreach(string item in planeetNamen) 
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (item == "jupiter") Console.BackgroundColor = ConsoleColor.Red;
                if (item == "pluto") Console.BackgroundColor = ConsoleColor.Green;
                double planeetGewicht = myWeight * planeetWeights[index];
                Console.WriteLine($"op {item} weeg je {planeetGewicht} kilo");
                index++;
            }
            Console.BackgroundColor = ConsoleColor.Black;


        }

        public static void floatTest() {
            float fl1 = 0.00001F;
            Console.WriteLine(fl1);
        }

    }
}
