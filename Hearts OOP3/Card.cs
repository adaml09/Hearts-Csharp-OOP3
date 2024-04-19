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
