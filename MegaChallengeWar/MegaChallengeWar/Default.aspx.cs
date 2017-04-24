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
            resultLabel.Text = "";
            Deck deck = new Deck();
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Game game = new Game(deck, player1, player2);
            Battle battle = new Battle();

            // Play 20 rounds
            while (battle.RoundCounter <= 20 
                && player1.PlayersCards.Count != 0 
                && player2.PlayersCards.Count != 0) 
            {
                battle.PlayRound(player1, player2);
                battle.RoundCounter++;    
                resultLabel.Text += battle.Result;
            }

            Player winner = new Player();
            winner = game.DetermineWinner(player1, player2);

            if (winner == null)
            {
                resultLabel.Text += $"<br /><br /><b>The game was a tie!</b>" +
                    $"<br />Player 1: {player1.PlayersCards.Count}" +
                    $"<br />Player 2: {player2.PlayersCards.Count}";
            }
            else
            {
                resultLabel.Text += $"<br /><br /><b>{winner.Name} wins the game!<b>" +
                    $"<br />Player 1: {player1.PlayersCards.Count}" +
                    $"<br />Player 2: {player2.PlayersCards.Count}";
            }   
        }
    }
}