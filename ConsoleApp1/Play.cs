using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Player;
using static ConsoleApp1.Issue;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Play
    {
        private int finalScore;
        private ConsoleApp1.Player[] players;

        public Play(int finalScore, Player[] players)
        {
            this.finalScore = finalScore;
            this.players = players;
        }

        public int FinalScore { get => finalScore; set => finalScore = value; }

        public void startGame()
        {
            Random r = new Random();
            ConsoleApp1.Issue issue = new Issue(1,7, r);

            while (this.isGameFinished())
            {
                foreach (Player player in players)
                {
                    player.Score += issue.getRandomNumber();
                    this.goBack(player);
                }
            }

           if (players[0].Score == this.finalScore)
                Console.WriteLine("*** Bravo ! Le joueur " + players[0].Name + " gagne la partie avec un score de " + players[0].Score + " ***");
           else
                Console.WriteLine("*** Bravo ! Le joueur " + players[1].Name + " gagne la partie avec un score de " + players[1].Score + " ***");
        }

        public bool isGameFinished()
        {
            return this.players[0].Score != this.finalScore && this.players[1].Score != this.finalScore;
        }

        public void goBack(Player player)
        {
            if (player.Score > 50)
            {
                player.Score = 25;
                Console.WriteLine("--- Le joueur " + player.Name + " retourne à 25");
            }
        }
    }
}
