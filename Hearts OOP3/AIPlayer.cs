using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Hearts_OOP3
{
    internal class AIPlayer : Player
    {
        private List<PlayingCard> Trick; // Store the current trick

        public AIPlayer(string name) : base(name)
        {
            Trick = new List<PlayingCard>();
        }

        public override Card SelectCardToPlay()
        {
            // Determine the leading suit based on the cards played in the current trick
            Card.Suit leadingSuit = DetermineLeadingSuit();

            // If the AI has cards of the leading suit, play the lowest card of that suit
            if (HasSuit(leadingSuit))
            {
                PlayingCard selectedPlayingCard = GetLowestCardOfSuit(leadingSuit);
                Hand.Remove(selectedPlayingCard); // Remove the selected card from the AI's hand
                return new Card((Card.Suit)selectedPlayingCard.Suit, selectedPlayingCard.Value); // Create a new Card object with the same suit and value
            }
            else // Otherwise, play a random card
            {
                Random random = new Random();
                int randomIndex = random.Next(Hand.Count);
                Card randomCard = Hand[randomIndex];
                Hand.RemoveAt(randomIndex);
                return randomCard;
            }
        }




        private Card.Suit DetermineLeadingSuit()
        {
            // Check if it's the first play of the trick (i.e., if the trick is empty)
            if (TrickIsEmpty())
            {
                // If it's the first play, return any suit or choose randomly
                Random random = new Random();
                return (Card.Suit)random.Next(Enum.GetValues(typeof(Card.Suit)).Length);
            }
            else
            {
                // Otherwise, return the suit of the first card played in the trick
                return Trick.First().Suit;
            }
        }

        private bool TrickIsEmpty()
        {
            // Check if the trick is empty (no cards have been played yet)
            return Trick.Count == 0;
        }

        private bool HasSuit(Card.Suit suit)
        {
            // Check if the AI player has cards of the specified suit
            return Hand.Any(card => card.Suit == suit);
        }

        private PlayingCard GetLowestCardOfSuit(Card.Suit suit)
        {
            // Get the lowest card of the specified suit from the AI player's hand
            // This assumes that the AI player has at least one card of the specified suit
            return Hand.Where(card => card.Suit == suit).OrderBy(card => card.Value).First();
        }
    }
}
