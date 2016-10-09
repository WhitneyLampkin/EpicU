using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    public class Deck
    {
        public const int TotalCards = 52;
        public List<Card> cardDeck { get; set; }
        
        Random random = new Random();
        
        
        public List<Card> Cards()
        {
            var cards = new List<Card>();

            string[] cardFace = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace"};
            string[] cardSuit = new string[] { "clubs", "diamonds", "hearts", "spades" };

            for (int i = 0; i < cardFace.Length-1; i++)
            {
                var clubs = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(0));
                var diamonds = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(1));
                var hearts = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(2));
                var spades = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(3));

                cards.Add(clubs);
                cards.Add(diamonds);
                cards.Add(hearts);
                cards.Add(spades);
            }

            return cards;
        }
        
        public void Shuffle()
        {
            cardDeck.OrderBy(a => Guid.NewGuid());
        }

        public void DealCards()
        {
            //Needs to alternate, be random & show who gets which cards.
        }

        private string showDeck()
        {
            var cards = cardDeck.ToString();
            foreach (var card in cards)
            {
                String.Format("Card: {0}</br>", card.ToString());
            }
            return cards;
        }
    }
}
