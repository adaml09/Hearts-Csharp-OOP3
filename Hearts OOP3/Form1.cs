namespace HEARTS
{
    public partial class Form1 : Form
    {
        // Define lists to hold PictureBox controls and card images
        private List<PictureBox> cardPictureBoxes = new List<PictureBox>();
        private List<Image> cardImages = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            LoadCardImages();
            InitializeCardPictureBoxes();
        }

        private void LoadCardImages()
        {
            // Load card images into the list from project resources
            // Replace Properties.Resources.card1 with your own images
            cardImages.Add(Properties.Resources._1Heart);
            cardImages.Add(Properties.Resources._1Spade);
            cardImages.Add(Properties.Resources._1Club);
            cardImages.Add(Properties.Resources._1Spade);
            cardImages.Add(Properties.Resources._10Club);
            cardImages.Add(Properties.Resources._10Heart);
            cardImages.Add(Properties.Resources._10Diamond);
            cardImages.Add(Properties.Resources._10Spade);
            cardImages.Add(Properties.Resources._2Club);
            cardImages.Add(Properties.Resources._2Heart);
            cardImages.Add(Properties.Resources._2Diamond);
            cardImages.Add(Properties.Resources._2Spade);
            cardImages.Add(Properties.Resources._4Club);
            cardImages.Add(Properties.Resources._4Heart);
            cardImages.Add(Properties.Resources._4Diamond);
            cardImages.Add(Properties.Resources._4Spade);
            cardImages.Add(Properties.Resources._6Club);
            cardImages.Add(Properties.Resources._6Heart);
            cardImages.Add(Properties.Resources._6Diamond);
            cardImages.Add(Properties.Resources._6Spade);
            cardImages.Add(Properties.Resources._8Club);
            cardImages.Add(Properties.Resources._8Heart);
            cardImages.Add(Properties.Resources._8Diamond);
            cardImages.Add(Properties.Resources._8Spade);
            cardImages.Add(Properties.Resources._QUEENClub);
            cardImages.Add(Properties.Resources._QUEENHeart);
            cardImages.Add(Properties.Resources._QUEENDiamond);
            cardImages.Add(Properties.Resources._QUEENSpade);

            // Add other card images here

        }

        // Method to initialize PictureBox controls for each card
        private void InitializeCardPictureBoxes()
        {
            // Create PictureBox controls for each card
            for (int i = 0; i < 5; i++) // Example: 5 cards
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(100, 150); // Set appropriate size for the PictureBox
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Set PictureBox to stretch image to fit
                pictureBox.Image = cardImages[i % cardImages.Count]; // Assign card image to PictureBox
                pictureBox.Click += Card_Click; // Attach event handler for card click
                cardPictureBoxes.Add(pictureBox); // Add PictureBox to the list for future reference

                // Arrange PictureBoxes on the form
                int x = 50 + i * 120; // Adjust x position for each PictureBox
                int y = 50; // Set y position (can be adjusted as needed)
                pictureBox.Location = new System.Drawing.Point(x, y); // Set PictureBox location
                this.Controls.Add(pictureBox); // Add PictureBox to the form's Controls collection
            }
        }

        // Event handler for card click event
        private void Card_Click(object sender, EventArgs e)
        {
            // Handle card click event
            PictureBox clickedCard = (PictureBox)sender; // Get the PictureBox that was clicked
            // Implement logic for card interaction here
            MessageBox.Show("You clicked a card!"); // Example: Show a message box indicating the card was clicked
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objective:\r\nThe objective of Hearts remains the same: avoid taking hearts cards and the Queen of Spades.\r\n\r\nGameplay:\r\n\r\nPassing: There's no passing in a two-player game. All players keep their cards.\r\n\r\nLeading: The player with the 2 of Clubs starts the first trick. In subsequent tricks, the winner of the previous trick leads.\r\n\r\nFollowing Suit: If possible, players must play a card of the same suit as the first card led. If they don't have cards in that suit, they can play any card.\r\n\r\nScoring: At the end of each hand, players score points based on the cards they've collected. Each Heart card is worth 1 point, and the Queen of Spades is worth 13 points. The goal is to collect as few points as possible.\r\n\r\nBreaking Hearts: In the first trick of the game, players cannot lead with a Heart card or the Queen of Spades unless they have no other cards.\r\n\r\nWinning: The game continues until all cards have been played. The player with the fewest points at the end wins.\r\n");
        }
    }
}
