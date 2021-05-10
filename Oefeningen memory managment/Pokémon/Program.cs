using System;
using System.Collections.Generic;

namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = new Log();
            log.WriteLine("Pokémon\n");
            List<Pokémon> pokemons = new List<Pokémon>();
            pokemons.Add(new Pokémon());
            pokemons.Add(new Pokémon());
            pokemons.Add(new Pokémon());

            InitBulbasaur(pokemons[0]);
            InitIvysaur(pokemons[1]);
            InitMewtwo(pokemons[2]);

            log.WriteLine();

            IPokémon pokémonMewtwo = pokemons[2];
            pokémonMewtwo.ShowInfo();

            //Console.WriteLine($"Attack_Full: {Mewtwo.Attack_Full}");
            //for (int i = 0; i<100;i++)
            //{
            //    Mewtwo.VerhoogLevel();
            //    Console.WriteLine($"Attack_Full: {Mewtwo.Attack_Full}");
            //}
        }

        static void InitBulbasaur(Pokémon Bulbasaur)
        {
            ILog log = new Log();
            Bulbasaur.Naam = "Bulbasaur";
            Bulbasaur.HP_Base = 45;
            Bulbasaur.Attack_Base = 49;
            Bulbasaur.Defense_Base = 49;
            Bulbasaur.SpecialAttack_Base = 65;
            Bulbasaur.SpecialDefense_Base = 65;
            Bulbasaur.Speed_Base = 45;
            log.WriteLine("Bulbasaur");
            log.WriteLine($"Total: {Bulbasaur.Total}");
            log.WriteLine($"Average: {Bulbasaur.Average}");
        }

        static void InitIvysaur(Pokémon Ivysaur)
        {
            ILog log = new Log();
            Ivysaur.Naam = "Ivysaur";
            Ivysaur.HP_Base = 60;
            Ivysaur.Attack_Base = 62;
            Ivysaur.Defense_Base = 63;
            Ivysaur.SpecialAttack_Base = 80;
            Ivysaur.SpecialDefense_Base = 80;
            Ivysaur.Speed_Base = 60;
            log.WriteLine("\nIvysaur");
            log.WriteLine($"Total: {Ivysaur.Total}");
            log.WriteLine($"Average: {Ivysaur.Average}");
        }

        static void InitMewtwo(Pokémon Mewtwo)
        {
            ILog log = new Log();
            Mewtwo.Naam = "Mewtwo";
            Mewtwo.HP_Base = 106;
            Mewtwo.Attack_Base = 110;
            Mewtwo.Defense_Base = 90;
            Mewtwo.SpecialAttack_Base = 154;
            Mewtwo.SpecialDefense_Base = 90;
            Mewtwo.Speed_Base = 130;
            log.WriteLine("\nMewtwo");
            log.WriteLine($"Total: {Mewtwo.Total}");
            log.WriteLine($"Average: {Mewtwo.Average}");
        }
    }
}
