using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playWarButton_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();

            foreach (var card in deck.DeckOfCards)
            {
                resultLabel.Text += $"<br />{card.CardNumber} of {card.CardSuit} is in deck.";
            }
        }
    }
}