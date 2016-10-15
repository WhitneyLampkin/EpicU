using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    public class Game
    {
        Random random = new Random();

        private Player player1 { get; set; }
        private Player player2 { get; set; }
        public List<Card> Deck { get; set; }

        public Game(string p1Name, string p2Name)
        {
            player1 = new Player("p1Name");
            player2 = new Player("p1Name");
            
            //var Deck = new List<Card>().OrderBy(a => Guid.NewGuid());
        }

        public string PlayGame()
        {
            var deck = new Deck();
            string result = " ";
            deck.DealCards(player1, player2);

            //result += String.Format("<br/> {0} received the following cards: {1} <br/>{2} received the following cards: {3}<br/>",
                //player1.Name, player2.Name, player1.Hand.ToString(), player2.Hand.ToString());

            while (player1.Hand.Count > 0 && player2.Hand.Count > 0)
            {
                var warGame = new War();
                warGame.startWarRound(player1, player2);
            }

            result += displayResults();

            return result;
 
        }
        private string displayStartMsg()
        {
            string result = "Dealing Card...";
            return result;

        }

        private string displayResults()
        {
            string result = "And the winnger is: ";

            if (player1.Hand.Count == 0) result += "<h2>Player 1 Wins</h2>";
            else result += "<h2>Player 2 Wins</h2>";

            return result;
        }
    }
}
