using System;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic\n");

            var manager = new Manager();
            manager.Cards.Add(new CreatureCard() { Health = 10, Attack =  10});
            manager.Cards.Add(new SpellCard() { Damage = 10});
            manager.Cards.Add(new LandCard());
            manager.Cards.Add(new ArtifactCard());

            if (manager.Cards[0] is CreatureCard)
            {
                var health = ((CreatureCard)manager.Cards[0]).Health;
                Console.WriteLine(health);
            }
            if (manager.Cards[1] is SpellCard)
            {
                var effect = ((SpellCard)manager.Cards[1]).Damage;
                Console.WriteLine(effect);
            }
        }
    }
}
