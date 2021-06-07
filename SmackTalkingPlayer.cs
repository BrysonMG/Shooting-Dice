using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; } = "Get ready to lose!";

        public override void Play(Player other)
        {
            Console.WriteLine($"{Name} said \"{Taunt}\"");
            base.Play(other);
        }
    }
}