// Author : Shah Bano and Adam LeBlanc
// Date: 2024-04-19
// Description: This is the form1, it has the actual game layout, a toolstrip with game rules, about us, and also picking which game mode the player wants
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Hearts_OOP3
{
    public partial class Form1 : Form
    {

        private List<PlayingCard> allCards = new List<PlayingCard>();
        // Declare class-level variables for card images


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCard(Card.Suit.Clubs, 10, "_10Club.png", 10);
            LoadCard(Card.Suit.Diamonds, 10, "_10Diamond.png", 10);
            LoadCard(Card.Suit.Hearts, 10, "_10Heart.png", 10);
            LoadCard(Card.Suit.Spades, 10, "_10Spade.png", 10);

            LoadCard(Card.Suit.Clubs, 1, "_1Club.png", 1);
            LoadCard(Card.Suit.Diamonds, 1, "_1Diamond.png", 1);
            LoadCard(Card.Suit.Hearts, 1, "_1Heart.png", 1);
            LoadCard(Card.Suit.Spades, 1, "_1Spade.png", 1);

            LoadCard(Card.Suit.Clubs, 2, "_2Club.png", 2);
            LoadCard(Card.Suit.Diamonds, 2, "_2Diamond.png", 2);
            LoadCard(Card.Suit.Hearts, 2, "_2Heart.png", 2);
            LoadCard(Card.Suit.Spades, 2, "_2Spade.png", 2);

            LoadCard(Card.Suit.Clubs, 4, "_4Club.png", 4);
            LoadCard(Card.Suit.Diamonds, 4, "_4Diamond.png", 4);
            LoadCard(Card.Suit.Hearts, 4, "_4Heart.png", 4);
            LoadCard(Card.Suit.Spades, 4, "_4Spade.png", 4);

            LoadCard(Card.Suit.Clubs, 6, "_6Club.png", 6);
            LoadCard(Card.Suit.Diamonds, 6, "_6Diamond.png", 6);
            LoadCard(Card.Suit.Hearts, 6, "_6Heart.png", 6);
            LoadCard(Card.Suit.Spades, 6, "_6Spade.png", 6);

            LoadCard(Card.Suit.Clubs, 8, "_8Club.png", 8);
            LoadCard(Card.Suit.Diamonds, 8, "_8Diamond.png", 8);
            LoadCard(Card.Suit.Hearts, 8, "_8Heart.png", 8);
            LoadCard(Card.Suit.Spades, 8, "_8Spade.png", 8);

            LoadCard(Card.Suit.Clubs, 12, "QueenClub.png", 12);
            LoadCard(Card.Suit.Diamonds, 12, "QueenDiamond.png", 12);
            LoadCard(Card.Suit.Hearts, 12, "QueenHeart.png", 12);
            LoadCard(Card.Suit.Spades, 12, "QueenSpade.png", 12);

        }

        private void LoadCard(Card.Suit suit, int rank, string imageName, int value)
        {
            Image image = Image.FromFile(@"Resources\" + imageName);
            PlayingCard card = new PlayingCard(suit, rank, image);
            allCards.Add(card);
        }

        private void howDoIWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate Form2
            Form2 form2 = new Form2();



            // Show Form2
            form2.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void minecraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minecraftTheme minecraftTheme = new minecraftTheme();
            minecraftTheme.Show();
        }

        private void spaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpaceTheme spaceTheme = new SpaceTheme();
            spaceTheme.Show();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
           allCards.
        }

        private void PlayCardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
