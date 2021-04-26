using System;
using System.Collections.Generic;
using System.Text;

namespace UML_naar_code
{
    class Boat
    {
        Engine motorBoot = new Engine();
        Propeller[] propellor = InitPropeller(); // array van lengte 1-4

        public static Propeller[] InitPropeller()
        {
            Console.Write("Hoeveel Pistons zijn er in de engine");
            int amountOfPropellers;
            while (!Int32.TryParse(Console.ReadLine(), out amountOfPropellers) || amountOfPropellers < 1 || amountOfPropellers > 4)
            {
                Console.Write("Hoeveel Pistons zijn er in de engine (geef valid int)");
            }
            return new Propeller[amountOfPropellers];
        }
    }
}
