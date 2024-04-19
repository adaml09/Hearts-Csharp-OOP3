using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;

namespace Hearts_OOP3
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override Card SelectCardToPlay()
        {

            // Display the player's hand
            Console.WriteLine($"{Name}'s Hand:");
            for (int i = 0; i < Hand.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Hand[i]}");
            }

            // Prompt the player to choose a card
            int selectedIndex;
            do
            {
                Console.Write("Select a card to play (1-13): ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out selectedIndex) || selectedIndex < 1 || selectedIndex > Hand.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 13.");
                }
                else
                {
                    selectedIndex--; // Convert to zero-based index
                    break;
                }
            } while (true);

            // Return the selected card
            Card selectedCard = Hand[selectedIndex];
            Hand.RemoveAt(selectedIndex);
            return selectedCard;
        }
    }
}
