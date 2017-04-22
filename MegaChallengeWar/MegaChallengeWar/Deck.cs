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
            
            generateCards(DeckOfCards);
        }

        private void determineSuit(int cardSuitCounter, out string suit)
        {
            if (cardSuitCounter == 0) suit = "Diamonds";
            else if (cardSuitCounter == 1) suit = "Hearts";
            else if (cardSuitCounter == 2) suit = "Clubs";
            else if (cardSuitCounter == 3) suit = "Spades";
            else suit = "nullSuit";

            return;
        }

        private void determineFaceCard(int cardNumberCounter, out string faceCardName)
        {
            if (cardNumberCounter == 0) faceCardName = "Jack";
            else if (cardNumberCounter == 1) faceCardName = "Queen";
            else if (cardNumberCounter == 2) faceCardName = "King";
            else if (cardNumberCounter == 3) faceCardName = "Ace";
            else faceCardName = "nullFace";

            return;
        }

        private void generateCards(List<Card> DeckOfCards)
        {
            bool isFaceCard = false;
            string suit = "";
            string faceCardName = "";
            for (int cardNumberCounter = 2; cardNumberCounter < 15; cardNumberCounter++) 
            {
                if (cardNumberCounter >= 11) isFaceCard = true;

                for (int cardSuitCounter = 0; cardSuitCounter < 4; cardSuitCounter++)
                {
                    determineSuit(cardSuitCounter, out suit);

                    if (isFaceCard)
                    {
                        determineFaceCard(cardNumberCounter, out faceCardName);
                        DeckOfCards.Add(new Card(cardNumberCounter, suit, faceCardName));
                    }
                    else DeckOfCards.Add(new Card(cardNumberCounter, suit));
                }
            }
        }
    }
}