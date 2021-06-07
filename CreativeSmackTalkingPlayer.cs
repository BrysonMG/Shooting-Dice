using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; } = new List<string>()
        {
            "You will lose", "You throw dice like a toddler", "Yahtzee!"
        };

        string GetRandomTaunt()
        {
            int RandomIndex = new Random().Next(Taunts.Count);
            return Taunts[RandomIndex];
        }

        public override void Play(Player other)
        {
            Console.WriteLine($"{Name} said \"{GetRandomTaunt()}\"");
            base.Play(other);
        }
    }
}