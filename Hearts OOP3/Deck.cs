using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts_OOP3
{
    internal class Deck
    {
        // Array that is the deck of card objects
        private Card[] deck;
        // Variable to hold the size of the deck
        private int deckSize;

        // Getters and setters
        public void SetDeckSize(int deckSize)
        {
            this.deckSize = deckSize;
        }

        public int GetDeckSize()
        {
            return deckSize;
        }

        // Parametrized constructor
        public Deck(int deckSize)
        {
            SetDeckSize(deckSize);
            this.Shuffle();
        }

        // Shuffles the deck by randomizing the order of the elements in the deck array
        public void Shuffle()
        {
            Random random = new Random();
            int i = 0;

            while (i < deckSize)
            {
                int s = i + random.Next(deckSize - i);
                Card temp = deck[s];
                deck[s] = deck[i];
                deck[i] = temp;
                i++;
            }
        }
    }
}
