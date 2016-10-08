using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDartsEpicU
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game(string p1Name, string p2Name)
        {
            var random = new Random();

            var Player1 = new Player();
            Player1.Name = p1Name;

            var Player2 = new Player();
            Player2.Name = p2Name;
        }

        public string playGame()
        {
            while (Player1.Score < 300 && Player2.Score < 300)
            {
                playRound(Player1);
                playRound(Player2);
            }

            return displayResults();
        }

        private void playRound(Player p)
        {
            for (int i = 0; i < 3; i++)
            {
                var random = new Random();
                var dartGame = new Darts.Dart(random);
                dartGame.Throw();

                Score.TotalDarts(p);
            }
        }

        private string displayResults()
        {
            string result = String.Format("Player 1 Score: {0} </br>Player 2 Score: {1}",
                Player1.Score,
                Player2.Score);

            return result;
        }
    }
}