using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PRO__Textbased_RPG
{
    public enum Directions
    {
        North, South, West, East
    }
    class Location
    {
        public Location()
        {
            Exits = new List(); //Een lijst van Exits, namelijk de richtingen waar de gebruiker naar toe kan gaan die aansluiten op een andere locatie
            ObjectsInRoom = new List(); //Een lijst van GameObjecten (items) die zich op deze locatie bevinden
        }
        public string Title { get; set; }
        public string Description { get; set; }

        public List Exits { get; set; }
        public List ObjectsInRoom { get; set; }

        public void Describe()
        {
            Console.WriteLine(Title + "\n*********");
            Console.WriteLine(Description);
            Console.WriteLine("Voorts zie je ook nog:");
            foreach (var objects in ObjectsInRoom)
            {
                objects.Describe();
            }
            Console.WriteLine("\n*********");
        }

        public Location GettLocationOnMove(Directions direction, List<GameObjects> playerInventory)
        {
            foreach (var exit in Exits)
            {
                if (exit.ExitDirection == direction)
                {

                    if (exit.TestPassCondition(playerInventory))
                        return exit.GoesToLocation;
                    else
                    {
                        Console.WriteLine("Je kan hier niet langs (je hebt niet alle vereiste items).");
                        return this;
                    }
                }
            }
            Console.WriteLine("Dat is geen geldige richting");
            return this;

        }
        //...
    }
}
