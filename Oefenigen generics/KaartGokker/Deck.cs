using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
{
    class Deck
    {
        public Deck()
        {
            KaartenSpel = new Stack<Speelkaart>();
            for (int y = 0; y < 4; y++)
            {
                for (int i = 0; i < 13; i++)
                {
                    KaartenSpel.Push(new Speelkaart() { Getal = (Getal)i, Suite = (Suite)y });
                }
            }
        }
        public Stack<Speelkaart> KaartenSpel { get; set; }

        public void SchuddenKaartenSpel()
        {
            Stack<Speelkaart> tempShuffleStack = new Stack<Speelkaart>();
            Stack<Speelkaart> tempShuffleStack2 = new Stack<Speelkaart>();
            Random rand = new Random();
            int rng;
            for (int i = 200 - 1; i >= 0; i--)
            {
                while (KaartenSpel.Count > 0)
                {
                    rng = rand.Next(0, 2);
                    if (rng == 0)
                    {
                        tempShuffleStack.Push(KaartenSpel.Pop());
                    }
                    else
                    {
                        tempShuffleStack2.Push(KaartenSpel.Pop());
                    }
                }
                while (tempShuffleStack.Count > 0)
                {
                    KaartenSpel.Push(tempShuffleStack.Pop());
                }
                while (tempShuffleStack2.Count > 0)
                {
                    KaartenSpel.Push(tempShuffleStack2.Pop());
                }
            }
        }
        public void TrekBovensteKaart()
        {
            Console.WriteLine(KaartenSpel.Pop());
        }
    }
}
