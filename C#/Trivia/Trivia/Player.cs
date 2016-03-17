using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Trivia
{
    class Player
    {
        public string Name;
        public int GoldCoins;
        public bool InPenaltyBox;
        public int Place;

        public Player(string playerName)
        {
            Name = playerName;
            GoldCoins = 0;
            InPenaltyBox = false;
            Place = 0;
        }
    }
}
