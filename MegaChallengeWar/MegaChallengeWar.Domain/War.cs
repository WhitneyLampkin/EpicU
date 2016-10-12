using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    public class War
    {
        private List<Card> bountyCards { get; set; }

        public War()
        {
            bountyCards = new List<Card>();
        }

        public void startWarRound(Player player1, Player player2)
        {
            var p1Card = getCard(player1);
            var p2Card = getCard(player2);

            evaluateCards(player1, player2, p1Card, p2Card);
        }

        private void awardBounty(Player player, List<Card> bountyCards)
        {
            player.Hand.AddRange(bountyCards);
            bountyCards.Clear();
            showHand(player);
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

        private Card getCard(Player player)
        {
            var card = player.Hand.ElementAt(0);
            player.Hand.Remove(card);
            bountyCards.Add(card);
            //displayWarCard();

            return card;
        }

        private void evaluateCards(Player player1, Player player2, Card card1, Card card2)
        {
            if (card1.CardValue() > card2.CardValue()) awardBounty(player1, bountyCards);
            else if (card2.CardValue() > card1.CardValue()) awardBounty(player2, bountyCards);
            else if (card1.CardValue() == card2.CardValue()) startWarRound(player1, player2);
        }

        private string displayBounty(List<Card> bountyCards)
        {
            var bounty = bountyCards.ToString();

            foreach (var card in bounty)
            {
                String.Format("Card: {0}</br>", card.ToString());
            }
            return bounty;
        }

        private string displayWarCard(Player player, Card card)
        {
            var warCard = card;
            var playerName = player.Name;

            string result = String.Format("{0}'s War Card: {1}</br>", playerName, warCard.ToString());
            return result;
        }
        
    }
}
