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
            
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            var game = new Game("Player 1", "Player 2");
            resultLabel.Text = game.PlayGame();

        }
    }
}