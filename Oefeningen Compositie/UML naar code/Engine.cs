using System;
using System.Collections.Generic;
using System.Text;

namespace UML_naar_code
{
    class Engine
    {
        Piston[] pistons = InitPistons(); // array van lengte 4-8
        Crankshaft krukas = new Crankshaft();   

        public static Piston[] InitPistons()
        {
            Console.Write("Hoeveel Pistons zijn er in de engine");
            int amountOfPistons;
            while (!Int32.TryParse(Console.ReadLine(), out amountOfPistons) || amountOfPistons<4 || amountOfPistons > 8)
            {
                Console.Write("Hoeveel Pistons zijn er in de engine (geef valid int)");
            }
            return new Piston[amountOfPistons];
        }
    }
}
