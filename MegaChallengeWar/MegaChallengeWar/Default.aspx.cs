using MegaChallengeWar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cards = new List<Card>();

            string[] cardFace = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            string[] cardSuit = new string[] { "clubs", "diamonds", "hearts", "spades" };

            for (int i = 0; i < cardFace.Length - 1; i++)
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
            var cardDeck = cards;

            foreach (var card in cards)
            {
                resultLabel.Text += String.Format("Card: {0}</br>", card.ToString());
            }
        }
    }
}