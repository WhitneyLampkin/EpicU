using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaChallengeWar.Domain
{
    class Game
    {
        Random random = new Random();

        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public List<Card> Deck { get; set; }

        private void playGame()
        {

        }

        private void playWarRound()
        {
            //If the cards are the same rank, it is War. Each player turns up one card face down and one card face up.
        }

        private string displayResults()
        {
            string result = "result";
            return result;
        }
    }
}
