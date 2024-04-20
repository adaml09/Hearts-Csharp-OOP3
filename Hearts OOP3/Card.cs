// Author: Adam LeBlanc
// Date: 2024-04-19
// Description: This is the card class which handles all the information about hte cards that are then held in the deck and displayed in the game.
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

}
