using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS309_Fa24_S03_Project_1
{
    public partial class formShoppingCart : Form
    {
        string[,] movies = new string[,]
       {
             { "1", "Avatar 2", "Sci-Fi Adventure", "8", "2022" },
              { "2", "Oppenheimer", "Historical Drama", "9", "2023" },
             { "3", "Barbie", "Comedy/Fantasy", "7", "2023" },
                { "4", "Shrek", "Comedy/Adventure", "8", "2001" },
                { "5", "Croods", "Comedy/Animation", "7", "2013" }
       };
        private string username1;
        public formShoppingCart(int intEnterID, int seatDolby, int seats3D, int seatReg, int totalCost, string username1)
        {
            InitializeComponent();

            lblInsertMovie.Text = movies[intEnterID-1, 1];
            lblNumDolby.Text = seatDolby.ToString();
            lblNum3D.Text = seats3D.ToString();
            lblNumReg.Text = seatReg.ToString();
           lblInsertTotal.Text = totalCost.ToString();
          
            this.username1 = username1;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string creditCardInput = txtbxInsertCreditCard.Text;
            string userName = txtbxUserName.Text.Trim();


            if (creditCardInput.Length != 11)
            {
                lblCreditMessage.Text = "Your credit card number does not contain 11 characters";
            }
                else if (!creditCardInput.All(char.IsDigit))
            {
                lblCreditMessage.Text = "Your credit card number must only contain numeric characters";
            }
            else if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please insert your username");
            }
             else if (userName != username1)
            {
                MessageBox.Show("Please insert your correct username");
            }
                else
            {
                lblCreditMessage.Text = "Your Credit Card Number contains 11 digits";
                MessageBox.Show("Payment Complete! Please take the receipt");
            }




        }

        private void btnReviewOrder_Click(object sender, EventArgs e)
        {
            formMovieTickets MovieTicketsform = new formMovieTickets(username1);
            MovieTicketsform.Show();
            this.Close();
        }
    }
}
