using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        public Deck()
        {
            string suit = "";
            string faceCardName = "";

            generateNonFaceCards(suit);
            generateFaceCards(suit, faceCardName);
        }

        private void determineSuit(int j, out string suit)
        {
            if (j == 0) suit = "Diamonds";
            else if (j == 1) suit = "Hearts";
            else if (j == 2) suit = "Clubs";
            else if (j == 3) suit = "Spades";
            else suit = "SuitError";

            return;
        }

        private void determineFaceCard(int i, out string faceCardName)
        {
            if (i == 0) faceCardName = "Jack";
            else if (i == 1) faceCardName = "Queen";
            else if (i == 2) faceCardName = "King";
            else if (i == 3) faceCardName = "Ace";
            else faceCardName = "ErrorFaceCardName";

            return;
        }

        private void generateFaceCards(string suit, string faceCardName)
        {
            for (int i = 0; i < 4; i++)
            {
                determineFaceCard(i, out faceCardName);

                // For loop to generate suit for face card
                for (int j = 0; j < 4; i++)
                {
                    determineSuit(j, out suit);
                    new Card(suit, faceCardName);
                }
            }
        }

        private void generateNonFaceCards(string suit)
        {
            for (int i = 0; i < 9; i++)
            {
                // To generate one of each suit
                for (int j = 0; j < 4; i++)
                {
                    determineSuit(j, out suit);

                    new Card(i, suit);
                }
            }
        }
       
    }
}