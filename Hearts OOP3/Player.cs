using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts_OOP3
{
    internal abstract class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; protected set; }
        public List<Card> CollectedCards { get; } // Add CollectedCards property

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            CollectedCards = new List<Card>(); // Initialize CollectedCards list
        }

        public abstract Card SelectCardToPlay();
    }
}
