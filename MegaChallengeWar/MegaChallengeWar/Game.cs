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
            Deck _deck = deck;
            dealOutDeck(_deck, player1, player2);
        }

        private void createPlayers()
        {

        }

        //Deal deck
        private void dealOutDeck(Deck _deck, Player player1, Player player2)
        {
            for (int i = 0; i < _deck.Cards.Count; i++)
            {
                player1.PlayersCards.Push(_deck.Cards.Pop());
                player2.PlayersCards.Push(_deck.Cards.Pop());
            }
        }

        

        //Perform battle loop

        //Determine who has most cards after 20 turns
    }
}
