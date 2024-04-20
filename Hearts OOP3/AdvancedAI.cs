// Author: Shah Bano & Adam LeBlanc
// Date: 2024-04-19
// Description: To fulfill the addition 2 modes in the game, we picked advanced ai, in which the ai will pick the lowest ranking card to determine a win.
//                Whilst AIPlayer only makes sure it plays the same suit card, making it easier for the human player to win
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts_OOP3
{
    internal class AdvancedAI : AIPlayer
    {
        public AdvancedAI(string name) : base(name)
        {
        }

        public override Card SelectCardToPlay()
        {
            // Determine the leading suit based on the cards played in the current trick
            Card.ge leadingSuit = DetermineLeadingSuit();

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

        private override Card GetLowestCardOfSuit(Card.Suit suit)
        {
            // Get the lowest card of the specified suit from the AI player's hand
            // This assumes that the AI player has at least one card of the specified suit
            // This plays a card of the correct suite and ensures that it is the optimal value each time
            // that makes it a more advanced AI
            return Hand.Where(card => card.Suit == suit).OrderBy(card => card.Value).First();
        }
    }
}
