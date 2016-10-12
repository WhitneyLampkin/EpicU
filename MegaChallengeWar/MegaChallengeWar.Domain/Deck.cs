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
        public List<Card> CardDeck { get; set; }
        private Random random { get; set; }
        
        public Deck()
        {
            var deck = new List<Card>();

            string[] cardFace = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace"};
            string[] cardSuit = new string[] { "clubs", "diamonds", "hearts", "spades" };

            for (int i = 0; i < cardFace.Length-1; i++)
            {
                //Don't forget to come back and refactor this code

                var clubs = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(0));
                var diamonds = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(1));
                var hearts = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(2));
                var spades = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(3));

                deck.Add(clubs);
                deck.Add(diamonds);
                deck.Add(hearts);
                deck.Add(spades);

                var cardID = Guid.NewGuid();
            }
        }

        public void Shuffle(List<Card> cards)
        {
            //I'm a little concerned about whether or not this will generate a new random deck each time. 
            //I'm hoping that the code will generate a new guid each time I call this method (for each new game).

            var deck = cards;
            deck.OrderBy(a => Guid.NewGuid());
        }

        public void DealCard(Player player1, Player player2)
        {
            var player1Hand = new List<Card>();
            var player2Hand = new List<Card>();
            var currentCard = CardDeck.FirstOrDefault<Card>();

            Shuffle(CardDeck);

            while (CardDeck.Count > 0)
            {
                player1Hand.Add(currentCard);
                CardDeck.Remove(currentCard);

                player2Hand.Add(currentCard);
                CardDeck.Remove(currentCard);
            }
        }

        private string displayDeck()
        {
            var cards = CardDeck.ToString();
            foreach (var card in cards)
            {
                String.Format("Card: {0}</br>", card.ToString());
            }
            return cards;
        }
    }
}
