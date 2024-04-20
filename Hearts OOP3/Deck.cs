// Author: Adam LeBlanc
// Date: 2024-04-19
// Description: This is the deck class which is designed to hold the cards that are played in the game.
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

        // returns the top card in the deck as well as removing it from the array
        public Card dealCard()
        {
            Card drawnCard;

            drawnCard = deck[0];

            // converts the array to a list to remove the top element the switches it back
            List<Card> cards = deck.ToList();
            cards.RemoveAt(0);
            deck = cards.ToArray();

            return drawnCard;

        }

    }

}
