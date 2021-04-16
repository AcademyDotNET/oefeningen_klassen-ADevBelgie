using System;
using System.Threading;

namespace Pokémon_battler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokémon-battler\n");

            //init poke 1
            Pokémon RandomPokemon = new Pokémon();
            GeneratorPokemon(RandomPokemon);
            RandomPokemon.ShowInfo();

            ////init OP poke 2
            //Pokémon Mewtwo = new Pokémon();
            //InitMewtwo(Mewtwo);
            //Mewtwo.ShowInfo();

            //init poke 3
            Pokémon RandomPokemon2 = new Pokémon();
            GeneratorPokemon(RandomPokemon2);
            RandomPokemon2.ShowInfo();

            ////battle
            //int result = Battle(RandomPokemon, Mewtwo);
            //Console.WriteLine($"result: {result}");

            ////battle of null's
            //Pokémon PokemonNull = new Pokémon();
            //int result2 = Battle(PokemonNull, RandomPokemon);
            //Console.WriteLine($"result: {result2}");
            do
            {
                int result3 = Battle(RandomPokemon, RandomPokemon2);
                if (result3 == 1)
                {
                    Console.WriteLine($"pokemon {RandomPokemon.Naam}1 won.");
                    RandomPokemon.VerhoogLevel();
                }
                else if(result3 == 2)
                {
                    Console.WriteLine($"pokemon {RandomPokemon2.Naam}2 won.");
                    RandomPokemon2.VerhoogLevel();
                }
                else
                {
                    Console.WriteLine("It was a draw.");
                }
                Thread.Sleep(2000);
            } while (RandomPokemon.Level < 99 && RandomPokemon2.Level < 99);
            
        }

        public static int Battle(Pokémon poke1 = null, Pokémon poke2 = null)
        {
            if (poke2 == null || poke1.Average_Full > poke2.Average_Full)
            {
                return 1;
            }
            else if (poke1 == null || poke1.Average_Full < poke2.Average_Full)
            {
                return 2;
            }
            else
            {
                return 0;
            }
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
        }

        public static void GeneratorPokemon(Pokémon randomPokemon)
        {
            Random rand = new Random();
            randomPokemon.Naam = "Random Pokemon";
            randomPokemon.HP_Base = rand.Next(10, 151);
            randomPokemon.Attack_Base = rand.Next(10, 151);
            randomPokemon.Defense_Base = rand.Next(10, 151);
            randomPokemon.SpecialAttack_Base = rand.Next(10, 151);
            randomPokemon.SpecialDefense_Base = rand.Next(10, 151);
            randomPokemon.Speed_Base = rand.Next(10, 151);
        }
    }
}
