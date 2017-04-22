using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        public List<Card> DeckOfCards = new List<Card>() { };

        public Deck()
        {
            string suit = "";
            string faceCardName = "";

            generateNonFaceCards(suit, DeckOfCards);
            generateFaceCards(suit, faceCardName, DeckOfCards);
        }

        private void determineSuit(int cardSuitCounter, out string suit)
        {
            if (cardSuitCounter == 0) suit = "Diamonds";
            else if (cardSuitCounter == 1) suit = "Hearts";
            else if (cardSuitCounter == 2) suit = "Clubs";
            else if (cardSuitCounter == 3) suit = "Spades";
            else suit = "SuitError";

            return;
        }

        private void determineFaceCard(int cardNumberCounter, out string faceCardName)
        {
            if (cardNumberCounter == 0) faceCardName = "Jack";
            else if (cardNumberCounter == 1) faceCardName = "Queen";
            else if (cardNumberCounter == 2) faceCardName = "King";
            else if (cardNumberCounter == 3) faceCardName = "Ace";
            else faceCardName = "FaceCardNameError";

            return;
        }

        private void generateNonFaceCards(string suit, List<Card> DeckOfCards)
        {
            for (int cardNumberCounter = 0; cardNumberCounter < 9; cardNumberCounter++) // Counter cardNumberCounter determines cardNumber
            {
                for (int cardSuitCounter = 0; cardSuitCounter < 3; cardSuitCounter++) // Counter cardSuitCounter determines suit
                {
                    determineSuit(cardSuitCounter, out suit);
                    DeckOfCards.Add(new Card(cardNumberCounter, suit));
                }
            }
        }

        private void generateFaceCards(string suit, string faceCardName, List<Card> DeckOfCards)
        {
            for (int cardNumberCounter = 11; cardNumberCounter < 15; cardNumberCounter++) // Counter cardNumberCounter determines cardNumber and faceCardName
            {
                determineFaceCard(cardNumberCounter, out faceCardName);

                for (int cardSuitCounter = 0; cardSuitCounter < 3; cardSuitCounter++) // Counter cardSuitCounter determines suit
                {
                    determineSuit(cardSuitCounter, out suit);
                    DeckOfCards.Add(new Card(cardNumberCounter, suit, faceCardName));
                }
            }
        }
    }
}