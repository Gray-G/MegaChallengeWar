using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        public int RoundCounter = 0;

        // Default battle
        public void PlayRound(Player player1, Player player2)
        {
            RoundCounter++;

            Card player1Card = new Card();
            Card player2Card = new Card();
            player1Card = player1.PlayersCards.Dequeue();
            player2Card = player2.PlayersCards.Dequeue();

            if (player1Card.CardNumber > player2Card.CardNumber)
            {
                winsRound(player1, player1Card, player2Card);
            }
            else if (player1Card.CardNumber < player2Card.CardNumber)
            {
                winsRound(player2, player2Card, player1Card);
            }
            else if (player1Card.CardNumber == player2Card.CardNumber)
            {
                Stack<Card> warStack = new Stack<Card>(); // warStack will hold the 'pot' of cards on the table and eventually goes to the winner
                warStack.Push(player1Card); // Push the original card that triggered war to the 'pot'
                warStack.Push(player2Card); // Push the original card that triggered war to the 'pot'
                performWarSequence(player1, player2, warStack);
            }
        }

        // Enqueue both cards from round into round-winner's deck
        private void winsRound(Player winner, Card winnerCard, Card opponentCard)
        {
            winner.PlayersCards.Enqueue(winnerCard);
            winner.PlayersCards.Enqueue(opponentCard);
        }

        // Enqueue each card from warStack into war-winner's deck
        private void winsWarRound(Player warWinner, Stack<Card> warStack)
        {
            for (int i = warStack.Count; i > 0; i--)
            {
                warWinner.PlayersCards.Enqueue(warStack.Pop());
            }
        }

        // Handle war here
        private void performWarSequence(Player player1, Player player2, Stack<Card> warStack)
        {
            // Prepare Player 1's war cards
            for (int i = 0; i < 3; i++)
            {
                warStack.Push(player1.PlayersCards.Dequeue());
            }   
            Card player1WarCardFlip = new Card();
            player1WarCardFlip = player1.PlayersCards.Dequeue();
            warStack.Push(player1WarCardFlip);

            // Prepare Player 2's war cards
            for (int i = 0; i < 3; i++)
            {
                warStack.Push(player2.PlayersCards.Dequeue());
            }
            Card player2WarCardFlip = new MegaChallengeWar.Card();
            player2WarCardFlip = player2.PlayersCards.Dequeue();
            warStack.Push(player2WarCardFlip);

            // Compare WarCarFlip.CardNumber to determine war winner
            if (player1WarCardFlip.CardNumber > player2WarCardFlip.CardNumber)
                winsWarRound(player1, warStack);
            else if (player1WarCardFlip.CardNumber < player2WarCardFlip.CardNumber)
                winsWarRound(player2, warStack);
            else
                performWarSequence(player1, player2, warStack);
        }

    }
}