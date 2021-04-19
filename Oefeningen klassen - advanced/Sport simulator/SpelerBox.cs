﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sport_simulator
{
    class SpelerBox
    {
        int _stamina = 1;
        int _strength = 1;
        int _reactionSpeed = 1;
        int _dexterity = 1;
        public string Naam { get; set; }

        public void StelIn()
        {
            Console.WriteLine($"init speler {Naam}");
            Console.WriteLine("geef stamina: ");
            _stamina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef strength: ");
            _strength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef reactie snelheid: ");
            _reactionSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef dexterity: ");
            _dexterity = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowOffStrength()
        {
            Console.WriteLine($"{Naam} doet een {_strength * 10} kg deadlift!");
        }

        public void RunMarathon()
        {
            Console.Write($"{Naam} probeert een marathon te lopen");
            if (_stamina > 40)
            {
                Console.WriteLine($" en is succesvol!");
            }
            else
            {
                Console.WriteLine($" en is niet succesvol...");
            }
        }
        public static void SimuleerSpeler(SpelerBox testspeler) 
        {
            for (int i = 0; i<3; i++)
            {
                testspeler.ShowOffStrength();
                testspeler.RunMarathon();
            }
        }
    }
}
