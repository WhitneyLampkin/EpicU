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
            var random = new Random();

            var dartGame = new Darts.Dart(random);

            dartGame.Throw();

            resultLabel.Text = String.Format("Score: {0} </br>Value: {1}</br>Band: {2}</br>Bullseye: {3}", 
                dartGame.Score,
                dartGame.Value,
                dartGame.Band,
                dartGame.Bullseye);
        }
    }
}