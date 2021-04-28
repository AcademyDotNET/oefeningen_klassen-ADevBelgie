using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker_all_in_one_project
{
    class Menu
    {
        public Menu()
        { }

        public void ShowMenu()
        { 
            //Tekenen
            TekenBalk(1);
            TekenOpties(2);
            TekenBalk(5);
        }
        private void TekenBalk(int hoogte)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, hoogte);
                Console.Write('*');
            }
        }
        private void TekenOpties(int hoogte)
        {
            Console.SetCursorPosition(5, hoogte);
            Console.Write("A) Voeg zetel toe op willekeurige locatie");
            Console.SetCursorPosition(5, hoogte + 1);
            Console.Write("B) Beweeg kaart naar beneden");
            Console.SetCursorPosition(5, hoogte + 2);
            Console.Write("Wat wilt u doen?...");
        }

        public void GetInput(List<MapObject> list)
        {
            int moveAmount = 1;
            string input = Console.ReadLine();
            if (input == "A" || input == "a")
            {
                //Voeg randomzetel toe
            }
            if (input == "B" || input == "b")
            {
                MoveKamerDown(list, moveAmount);
            }
        }

        private void MoveKamerDown(List<MapObject> Kamer, int moveAmount)
        {
            //zwart maken alle objecten
            Console.ForegroundColor = ConsoleColor.Black;
            foreach (var Object in Kamer)
            {
                Object.Paint();
            }
            //verander locatie objecten.. print deze niet.
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < Kamer.Count; i++)
            {
                Kamer[i].Location = new Point(Kamer[i].Location.X, Kamer[i].Location.Y + moveAmount);
            }
        }
    }
}
