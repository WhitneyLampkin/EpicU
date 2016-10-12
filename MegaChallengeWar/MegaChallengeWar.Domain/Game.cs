using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    class Game
    {
        Random random = new Random();

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public List<Card> Deck { get; set; }

        public Game(string p1Name, string p2Name, List<Card> cardDeck)
        {
            var Player1 = new Player();
            Player1.Name = p1Name;

            var Player2 = new Player();
            Player2.Name = p2Name;

            //Check to see if ordering the deck will also shuffle. 
            //If so, this may work since this code should generate a new Guid each time a game is started. 
            var gameDeck = new List<Card>().OrderBy(a => Guid.NewGuid());
        }

        private void playGame(List<Card> deck, Player player1, Player player2)
        {
            var cardDeck = deck;
            var player1Name = player1.Name;
            var player2Name = player2.Name;

            
        }

        private void playWarRound()
        {
            //If the cards are the same rank, it is War. Each player turns up one card face down and one card face up.
        }

        private string displayResults()
        {
            string result = "result";
            return result;
        }

        public void scoreRound(Card p1Card, Card p2Card)
        {
            //Add switch statement
        }
    }
}
