using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
        private Guid CardId { get; set; }

        public int CardValue()
        {
            int value = 0;

            switch (Face)
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(Face);
                    break;
            }
            return value;
        }

        //We need a card Constructor 
        public Card(string cardFace, string cardSuit, Guid id)
        {
            var cardId = id;

            Face = cardFace;
            Suit = cardSuit;
        }

        public override string ToString()
        {
            return Face + "_" + "of" + "_" + Suit;
        }

        public string getImageName(Card card)
        {
            string imageName = String.Format("{0}" + ".png", card.ToString());
            return imageName;
        }
    }
}
