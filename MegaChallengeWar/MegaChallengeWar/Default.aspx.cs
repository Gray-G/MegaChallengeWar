using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MegaChallengeWar;

namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playWarButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Player1", "Player2");
            resultLabel.Text = game.Play();
        }
    }
}