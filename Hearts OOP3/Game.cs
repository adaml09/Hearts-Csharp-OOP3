using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hearts_OOP3
{
    internal class Game
    {
        private Deck deck;
        private List<Player> players;
        private List<Card> currentTrick = new List<Card>();
        private const int NumPlayers = 2;
        private int currentPlayerIndex = 0;



        public Game()
        {

            deck = new Deck();
            players = new List<Player>();
            players.Add(new HumanPlayer("Player 1")); // Create an instance of HumanPlayer
            players.Add(new HumanPlayer("Player 2")); // Create another instance of HumanPlayer
            deck.Shuffle();
        }



        private void DealCardsToPlayers()
        {
            int numCardsToDeal = deck.DeckSize / players.Count;
            foreach (var player in players)
            {
                for (int i = 0; i < numCardsToDeal; i++)
                {
                    Card dealtCard = deck.DealCard();
                    player.Hand.Add(dealtCard);
                }
            }
        }


        public void PlayCard(Player player, Card card)
        {
            currentTrick.Add(card);

            if (currentTrick.Count == NumPlayers)
            {
                Card winningCard = DetermineWinningCard();
                Player winningPlayer = DetermineWinningPlayer(winningCard);
                AwardTrickToPlayer(winningPlayer);
                PrepareNextTrick();
            }
        }

        private Card DetermineWinningCard()
        {
            Card.Suit leadingSuit = currentTrick[0].CardSuit;

            Card winningCard = currentTrick
                .Where(card => card.CardSuit == leadingSuit)
                .OrderByDescending(card => card.Value)
                .First();

            if (winningCard.CardSuit == Card.Suit.Hearts)
            {
                bool otherHeartsPlayed = currentTrick.Any(card => card.CardSuit == Card.Suit.Hearts && card != winningCard);
                if (!otherHeartsPlayed)
                {
                    leadingSuit = Card.Suit.Hearts;
                }
            }

            if (leadingSuit == Card.Suit.Hearts)
            {
                winningCard = currentTrick
                    .Where(card => card.CardSuit == Card.Suit.Hearts)
                    .OrderByDescending(card => card.Value)
                    .First();
            }

            return winningCard;
        }

        private Player DetermineWinningPlayer(Card winningCard)
        {
            Player winningPlayer = null;
            foreach (var card in currentTrick)
            {
                if (card.Equals(winningCard))
                {
                    winningPlayer = players[currentPlayerIndex];
                    break;
                }
                currentPlayerIndex = (currentPlayerIndex + 1) % NumPlayers;
            }

            Player otherPlayer = players[(currentPlayerIndex + 1) % NumPlayers];

            return otherPlayer;
        }

        private void AwardTrickToPlayer(Player player)
        {
            player.CollectedCards.AddRange(currentTrick);
            currentTrick.Clear();
        }

        private void PrepareNextTrick()
        {
            currentTrick.Clear();
            foreach (var player in players)
            {
                player.Hand.Clear();
                player.Hand.AddRange(DealCardsToPlayers());
            }
            currentPlayerIndex = 0;
        }
    }
}
