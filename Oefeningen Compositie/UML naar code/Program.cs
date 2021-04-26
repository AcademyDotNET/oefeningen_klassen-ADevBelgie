using System;

namespace UML_naar_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UML naar code!\n");

            Person arthur = new Person();

            Console.WriteLine("Init Car");
            Car arthursAuto = new Car();

            Console.WriteLine("Init Boat");
            Boat arthursBoot = new Boat();
        }
    }
}
