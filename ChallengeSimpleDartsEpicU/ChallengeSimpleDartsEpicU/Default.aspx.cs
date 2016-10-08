using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDartsEpicU
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var random = new Random();
            //var dartGame = new Darts.Dart(random);
            //dartGame.Throw();
            
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            var game = new Game("Player 1", "Player 2");
            string result = game.playGame();
            resultLabel.Text = result;
        }
    }
}