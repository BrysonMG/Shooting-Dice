using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 100; x++)
            {

                Console.WriteLine("+1 inside......" + new Random().Next(1, 11));

                Console.WriteLine("+1 outside......" + new Random().Next(1, 10) + 1);
            }


            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            Player player4 = new SmackTalkingPlayer();
            player4.Name = "Kyle";

            player4.Play(player1);

            Console.WriteLine("-------------------");

            Player cheater = new OneHigherPlayer();
            cheater.Name = "Cheaty McCheaterson";

            cheater.Play(large);

            Console.WriteLine("-------------------");

            Player me = new HumanPlayer();
            me.Name = "Bryson";

            me.Play(player3);

            Console.WriteLine("-------------------");

            Player TheKaren = new CreativeSmackTalkingPlayer();
            TheKaren.Name = "Karen";

            TheKaren.Play(player4);

            Console.WriteLine("-------------------");

            Player playerX = new SoreLoserPlayer();
            playerX.Name = "The Sore Loser";

            playerX.Play(TheKaren);

            Console.WriteLine("-------------------");

            Player OnlyHighs = new UpperHalfPlayer();
            OnlyHighs.Name = "No Lows";

            OnlyHighs.Play(large);

            Console.WriteLine("-------------------");

            Player OnlyHighsSoreLoser = new SoreLoserUpperHalfPlayer();
            OnlyHighsSoreLoser.Name = "Jake from State Farm";

            OnlyHighsSoreLoser.Play(playerX);

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, player4, cheater, me
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}