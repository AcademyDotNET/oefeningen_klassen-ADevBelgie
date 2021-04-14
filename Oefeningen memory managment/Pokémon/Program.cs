using System;

namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokémon\n");
            Pokémon Bulbasaur = new Pokémon();
            InitBulbasaur(Bulbasaur);

            Pokémon Ivysaur = new Pokémon();
            InitIvysaur(Ivysaur);

            Pokémon Mewtwo = new Pokémon();
            InitMewtwo(Mewtwo);

            Console.WriteLine();
            Mewtwo.ShowInfo();

            //Console.WriteLine($"Attack_Full: {Mewtwo.Attack_Full}");
            //for (int i = 0; i<100;i++)
            //{
            //    Mewtwo.VerhoogLevel();
            //    Console.WriteLine($"Attack_Full: {Mewtwo.Attack_Full}");
            //}
        }

        static void InitBulbasaur(Pokémon Bulbasaur)
        {
            Bulbasaur.Naam = "Bulbasaur";
            Bulbasaur.HP_Base = 45;
            Bulbasaur.Attack_Base = 49;
            Bulbasaur.Defense_Base = 49;
            Bulbasaur.SpecialAttack_Base = 65;
            Bulbasaur.SpecialDefense_Base = 65;
            Bulbasaur.Speed_Base = 45;
            Console.WriteLine("Bulbasaur");
            Console.WriteLine($"Total: {Bulbasaur.Total}");
            Console.WriteLine($"Average: {Bulbasaur.Average}");
        }

        static void InitIvysaur(Pokémon Ivysaur)
        {
            Ivysaur.Naam = "Ivysaur";
            Ivysaur.HP_Base = 60;
            Ivysaur.Attack_Base = 62;
            Ivysaur.Defense_Base = 63;
            Ivysaur.SpecialAttack_Base = 80;
            Ivysaur.SpecialDefense_Base = 80;
            Ivysaur.Speed_Base = 60;
            Console.WriteLine("\nIvysaur");
            Console.WriteLine($"Total: {Ivysaur.Total}");
            Console.WriteLine($"Average: {Ivysaur.Average}");
        }

        static void InitMewtwo(Pokémon Mewtwo)
        {
            Mewtwo.Naam = "Mewtwo";
            Mewtwo.HP_Base = 106;
            Mewtwo.Attack_Base = 110;
            Mewtwo.Defense_Base = 90;
            Mewtwo.SpecialAttack_Base = 154;
            Mewtwo.SpecialDefense_Base = 90;
            Mewtwo.Speed_Base = 130;
            Console.WriteLine("\nMewtwo");
            Console.WriteLine($"Total: {Mewtwo.Total}");
            Console.WriteLine($"Average: {Mewtwo.Average}");
        }
    }
}
