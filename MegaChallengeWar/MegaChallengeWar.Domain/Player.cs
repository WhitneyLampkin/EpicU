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

        private string showHand()
        {
            var playerHand = new List<Card>();

            var cards = playerHand.ToString();
            foreach (var card in cards)
            {
                String.Format("Card: {0}</br>", card.ToString());
            }
            return cards;
        }

        //private void claimBounty(List<Card> bounty)
        //{
        //    //When the player wins the bounty, all of the bounty cards should be added to their list of cards.

        //    var bountyCards = bounty;
            
        //}

        public void playCard(List<Card> playerHand)
        {
            //In the UI, we want the card's image to be shown when played.

            var hand = playerHand;
            var currentCard = hand.First();
        }
    }
}
