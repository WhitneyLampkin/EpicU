using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Card> Hand { get; set; }

        private void showHand()
        {
            //var cards = CardDeck.ToString();
            //foreach (var card in cards)
            //{
            //    String.Format("Card: {0}</br>", card.ToString());
            //}
            //return cards;
        }

        private void claimBounty()
        {
            //When the player wins the bounty, all of the bounty cards should be added to their list of cards.
        }

        public void playCard()
        {
            //In the UI, we want the card's image to be shown when played.
        }
    }
}
