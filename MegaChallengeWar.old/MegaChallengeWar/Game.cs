using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        //Instantiate deck, players
        public Game(Deck deck, Player player1, Player player2)
        {
            dealOutDeck(deck, player1, player2);
        }

        //Deal deck
        private void dealOutDeck(Deck deck, Player player1, Player player2)
        {
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                player1.PlayersCards.Enqueue(deck.Cards.Pop());
                player2.PlayersCards.Enqueue(deck.Cards.Pop());
            }
        }

        public Player DetermineWinner(Player player1, Player player2)
        {
            if (player1.PlayersCards.Count > player2.PlayersCards.Count)
                return player1;
            else if (player1.PlayersCards.Count < player2.PlayersCards.Count)
                return player2;
            else return null; // Returning 'null' means a tie
        }
    }
}
