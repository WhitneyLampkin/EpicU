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
        public Guid CardId { get; set; }
        private Random random { get; set; }
        
        public Deck()
        {
            var CardDeck = new List<Card>();
            CardId = Guid.NewGuid();

            string[] cardFace = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace"};
            string[] cardSuit = new string[] { "clubs", "diamonds", "hearts", "spades" };

            for (int i = 0; i < cardFace.Length-1; i++)
            {
                var clubs = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(0), CardId);
                var diamonds = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(1), CardId);
                var hearts = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(2), CardId);
                var spades = new Card(cardFace.ElementAt(i), cardSuit.ElementAt(3), CardId);

                CardDeck.Add(clubs);
                CardDeck.Add(diamonds);
                CardDeck.Add(hearts);
                CardDeck.Add(spades);

                //foreach (var suit in cardSuit)
                //{
                //    CardDeck.Add(new Card(cardFace.ElementAt(i), cardSuit.ElementAt(i), CardId));
                //}
            }
        }

        /*public void Shuffle(List<Card> cards)
        {
            //I'm a little concerned about whether or not this will generate a new random deck each time. 
            //I'm hoping that the code will generate a new guid each time I call this method (for each new game).
            var deck = cards;
            deck.OrderBy(a => Guid.NewGuid());
        }*/

        public void DealCards(Player player1, Player player2)
        {
            var deck = new List<Card>();

            while (deck.Count > 0)
            {
                DealCard(player1);
                DealCard(player2);
            }
            
        }

        public string DealCard(Player player)
        {
            var playerHand = new List<Card>();
            var currentCard = CardDeck.ElementAt(random.Next(CardDeck.Count));
            
                playerHand.Add(currentCard);
                CardDeck.Remove(currentCard);

            return playerHand.ToString();
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
