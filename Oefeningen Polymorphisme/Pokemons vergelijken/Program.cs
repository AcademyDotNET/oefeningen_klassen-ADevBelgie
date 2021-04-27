using System;

namespace Pokemons_vergelijken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokemons_vergelijken\n");

            //random pokemon to compare
            Pokémon Bulbasaur = new Pokémon();
            InitBulbasaur(Bulbasaur);
            Console.WriteLine(Bulbasaur);

            //User pokemon base stats
            Pokémon UserPokemon = new Pokémon();
            MakeYourPokemon(UserPokemon);
            Console.WriteLine(UserPokemon);

            //User pokemon level
            Console.WriteLine("what level do you want your pokemon (1-99)");
            int wantedLevel = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < wantedLevel; i++)
            {
                UserPokemon.VerhoogLevel();
            }

            //output result
            Console.WriteLine(UserPokemon);

            Console.WriteLine(UserPokemon.Equals(Bulbasaur));
        }

        private static void MakeYourPokemon(Pokémon UserPokemon)
        {
            Console.WriteLine("Name you pokemon: ");
            UserPokemon.Naam = Console.ReadLine();
            Console.WriteLine("base hp: ");
            UserPokemon.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("base attack: ");
            UserPokemon.Attack_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("base defence: ");
            UserPokemon.Defense_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("base SP attack: ");
            UserPokemon.SpecialAttack_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("base SP defence: ");
            UserPokemon.SpecialDefense_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("base speed: ");
            UserPokemon.Speed_Base = Convert.ToInt32(Console.ReadLine());
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
        }
    }
}
