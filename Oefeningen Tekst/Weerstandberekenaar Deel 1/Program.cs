using System;

namespace Weerstandberekenaar_Deel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kleurcode = new int[4];
            string[] colors = { "grijs", "goud", "zwart", "bruin", "rood", "oranje", "geel", "groen", "blauw", "paars", "grijs", "wit" };
            Console.WriteLine("Dit programma gaat de weerstand bereken met behulp van de ingegeven kleurcode\n");
            Console.WriteLine("Geef de kleur van ring 1: ");
            do
            {
                kleurcode[0] = GetColor(colors);
                if (kleurcode[0] == 1) Console.WriteLine("dit is geen valide kleur voor de eerste ring, u leest de weerstand achterstevoren.");
                if (kleurcode[0] == 0) kleurcode[0] = 10;
            } while (kleurcode[0] == 1);

            Console.WriteLine("Geef de kleur van ring 2: ");
            do
            {
                kleurcode[1] = GetColor(colors);
                if (kleurcode[1] == 1) Console.WriteLine("dit is geen valide kleur voor de tweede ring");
                if (kleurcode[1] == 0) kleurcode[1] = 10;
            } while (kleurcode[1] == 1);
            Console.WriteLine("Geef de kleur van ring 3: ");
            do
            {
                kleurcode[2] = GetColor(colors);
                if (kleurcode[2] > 9) Console.WriteLine("dit is geen valide kleur voor de derde ring");
            } while (kleurcode[2] > 9);
            Console.WriteLine("Geef de kleur van ring 4: ");
            do
            {
                kleurcode[3] = GetColor(colors);
                if (kleurcode[3] > 4) Console.WriteLine("dit is geen valide kleur voor de vierde ring");
            } while (kleurcode[3] > 4);

            //bereken weerstandswaarde met kleurencode.
            string sWeerstand = $"{kleurcode[0] - 2}{kleurcode[1] - 2}";
            double dWeerstand = (Convert.ToInt32(sWeerstand)) * Math.Pow(10, (kleurcode[2] - 2));

            Console.WriteLine($"{dWeerstand}"); // weerstand waarde.
            // tolerantie waarde wordt niet berekent.
        }

        static int GetColor(string[] colors)
        {
            int color = 0;

            do
            {
                if (color > 0) Console.WriteLine("geef een valide kleur in:");

                string colorText = Console.ReadLine();
                color = 0;

                while (color < 12 && colorText != colors[color])
                {
                    color++;
                }
            } while (color >= 12);

            return color;
        }
    }
}
