using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Card> Hand { get; set; }

        //constructor
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        private string showHand(Player player)
        {
            var playerHand = new List<Card>();

            var cards = playerHand.ToString();
            foreach (var card in cards)
            {
                String.Format("Card: {0}</br>", card.ToString());
            }
            return cards;
        }

        public void playCard(List<Card> playerHand)
        {
            //In the UI, we want the card's image to be shown when played.

            var hand = playerHand;
            var currentCard = hand.First();
        }
    }
}
