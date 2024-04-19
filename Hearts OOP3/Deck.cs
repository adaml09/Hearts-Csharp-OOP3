using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts_OOP3
{
    internal class Card
    {
        // Variables for values of the object
        private string suit;
        private int value;

        // Default values to be used in the default constructor
        private static string DEFAULT_SUIT = "Hearts";
        private static int DEFAULT_VALUE = 1;

        // Getters and setters
        public string GetSuit()
        {
            return suit;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetSuit(string suit)
        {
            this.suit = suit;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        // Default constructor
        public Card()
        {
            SetSuit(DEFAULT_SUIT);
            SetValue(DEFAULT_VALUE);
        }

        // Parametrized constructor
        public Card(string suit, int value)
        {
            SetSuit(suit);
            SetValue(value);
        }
    }

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

    public class PlayingCard
    {
        public Card.Suit Suit { get; }
        public int Value { get; }
        public Image Image { get; }

        public PlayingCard(Card.Suit suit, int value, Image image)
        {
            Suit = suit;
            Value = value;
            Image = image;
        }
    }
}
