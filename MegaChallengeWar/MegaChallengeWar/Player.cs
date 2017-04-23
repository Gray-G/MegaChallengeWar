﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Player
    {
        public string Name = "";

        public Player(string name)
        {
            Name = name;
        }

        public Player() { }

        public Queue<Card> PlayersCards = new Queue<Card>() { };
    }
}