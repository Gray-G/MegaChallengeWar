using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        public int CardNumber { get; set; }
        public string CardSuit { get; set; }
        public string FaceCardName { get; set; }

        public Card(int cardNumber, string cardSuit)
        {
            CardNumber = cardNumber;
            CardSuit = cardSuit;
        }

        public Card(string cardSuit, string faceCardName)
        {
            CardSuit = cardSuit;
            FaceCardName = faceCardName;
        }
    }
}