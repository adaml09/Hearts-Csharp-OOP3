﻿namespace Hearts_OOP3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripTextBox1 = new ToolStripDropDownButton();
            howDoIWinToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            advancedAIVsYouToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            classicToolStripMenuItem = new ToolStripMenuItem();
            paintingToolStripMenuItem = new ToolStripMenuItem();
            spaceToolStripMenuItem = new ToolStripMenuItem();
            minecraftToolStripMenuItem = new ToolStripMenuItem();
            DealButton = new Button();
            pictureBox1 = new PictureBox();
            PlayCardButton = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripTextBox1.DropDownItems.AddRange(new ToolStripItem[] { howDoIWinToolStripMenuItem, aboutUsToolStripMenuItem });
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(55, 24);
            toolStripTextBox1.Text = "Help";
            // 
            // howDoIWinToolStripMenuItem
            // 
            howDoIWinToolStripMenuItem.Name = "howDoIWinToolStripMenuItem";
            howDoIWinToolStripMenuItem.Size = new Size(187, 26);
            howDoIWinToolStripMenuItem.Text = "How do I win?";
            howDoIWinToolStripMenuItem.Click += howDoIWinToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(187, 26);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, advancedAIVsYouToolStripMenuItem, themeToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(62, 24);
            toolStripDropDownButton1.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(224, 26);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // advancedAIVsYouToolStripMenuItem
            // 
            advancedAIVsYouToolStripMenuItem.Name = "advancedAIVsYouToolStripMenuItem";
            advancedAIVsYouToolStripMenuItem.Size = new Size(224, 26);
            advancedAIVsYouToolStripMenuItem.Text = "Advanced AI vs You";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { classicToolStripMenuItem, paintingToolStripMenuItem, spaceToolStripMenuItem, minecraftToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(224, 26);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // classicToolStripMenuItem
            // 
            classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            classicToolStripMenuItem.Size = new Size(224, 26);
            classicToolStripMenuItem.Text = "Classic";
            // 
            // paintingToolStripMenuItem
            // 
            paintingToolStripMenuItem.Name = "paintingToolStripMenuItem";
            paintingToolStripMenuItem.Size = new Size(224, 26);
            paintingToolStripMenuItem.Text = "Painting";
            // 
            // spaceToolStripMenuItem
            // 
            spaceToolStripMenuItem.Name = "spaceToolStripMenuItem";
            spaceToolStripMenuItem.Size = new Size(224, 26);
            spaceToolStripMenuItem.Text = "Space";
            spaceToolStripMenuItem.Click += spaceToolStripMenuItem_Click;
            // 
            // minecraftToolStripMenuItem
            // 
            minecraftToolStripMenuItem.Name = "minecraftToolStripMenuItem";
            minecraftToolStripMenuItem.Size = new Size(224, 26);
            minecraftToolStripMenuItem.Text = "Minecraft";
            minecraftToolStripMenuItem.Click += minecraftToolStripMenuItem_Click;
            // 
            // DealButton
            // 
            DealButton.Location = new Point(47, 321);
            DealButton.Name = "DealButton";
            DealButton.Size = new Size(109, 29);
            DealButton.TabIndex = 1;
            DealButton.Text = "Deal";
            DealButton.UseVisualStyleBackColor = true;
            DealButton.Click += DealButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PlayCardButton
            // 
            PlayCardButton.Location = new Point(664, 384);
            PlayCardButton.Name = "PlayCardButton";
            PlayCardButton.Size = new Size(94, 29);
            PlayCardButton.TabIndex = 3;
            PlayCardButton.Text = "Play Card";
            PlayCardButton.UseVisualStyleBackColor = true;
            PlayCardButton.Click += PlayCardButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(PlayCardButton);
            Controls.Add(pictureBox1);
            Controls.Add(DealButton);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripTextBox1;
        private ToolStripMenuItem howDoIWinToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private Button DealButton;
        private PictureBox pictureBox1;
        private Button PlayCardButton;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem advancedAIVsYouToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem classicToolStripMenuItem;
        private ToolStripMenuItem paintingToolStripMenuItem;
        private ToolStripMenuItem spaceToolStripMenuItem;
        private ToolStripMenuItem minecraftToolStripMenuItem;
    }
}