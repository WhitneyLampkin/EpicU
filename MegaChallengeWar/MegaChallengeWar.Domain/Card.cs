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
        public Guid CardId { get; set; }

        //We need a card Constructor 
        public Card(string cardFace, string cardSuit)
        {
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
