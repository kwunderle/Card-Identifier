using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/08/2021
    //Goal: To identify a card by name when the image is clicked on.
    public partial class cardIdentifier : Form
    {
        public cardIdentifier()
        {
            InitializeComponent();
        }

        private void aceofheartsPicture_Click(object sender, EventArgs e)
        {
            //Display Ace of Hearts in cardnameLabel when image is clicked.
            cardnameLabel.Text = "Ace of Hearts";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits out of program.
            this.Close();
        }

        private void eightofspadesPicture_Click(object sender, EventArgs e)
        {
            //Display Eight of Spades in cardnameLabel when image is clicked.
            cardnameLabel.Text = "Eight of Spades";
        }

        private void queenofheartsPicture_Click(object sender, EventArgs e)
        {
            //Display Queen of Hearts in cardnameLabel when image is clicked.
            cardnameLabel.Text = "Queen of Hearts";
        }

        private void jackofclubsPicture_Click(object sender, EventArgs e)
        {
            //Display Jack of Clubs in cardnameLabel when image is clicked.
            cardnameLabel.Text = "Jack of Clubs";
        }

        private void sevenofheartsPicture_Click(object sender, EventArgs e)
        {
            //Display Seven of Hearts in cardnameLabel when image is clicked.
            cardnameLabel.Text = "Seven of Hearts";
        }
    }
}
