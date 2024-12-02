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
    public partial class formMovieTickets : Form
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
        public formMovieTickets(string username1)
        {
            InitializeComponent();
            this.username1 = username1;
        }

        private void btnMovieID_Click(object sender, EventArgs e)
        {
            string enteredID;
            int movieID;
            //makes sure that no spaces are added that can cause error


            enteredID = txtbxMovieID.Text.Trim();

            //if text box empty, displays message of put a ID inside
            if (string.IsNullOrEmpty(enteredID))
            {
                MessageBox.Show("ERROR: Please input a movie ID listed from the right");
                return;
            }

            if (!int.TryParse(enteredID, out movieID))
            {
                MessageBox.Show("ERROR: Please input a valid single-digit number.");
                return;
            }

            //if number is not within 1-5, there is an error
            if (movieID < 1 || movieID > 5)
            {
                MessageBox.Show("Please enter valid MovieID");
                return;
            }


            for (int i = 0; i < movies.GetLength(0); i++) // rows
            {
                if (movies[i, 0] == enteredID) // Compare the ID
                {
                    // Update labels with movie details
                    lblMovieTitle.Text = movies[i, 1];
                    lblMovieGenre.Text = movies[i, 2];
                    lblMovieIMDb.Text = movies[i, 3] + "/10";
                    lblMovieReleaseDate.Text = movies[i, 4];
                    return;
                }
            }

        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {

            string enteredID;
            string resultMessage;
            int seatDolby = (int)numDolby.Value;
            int seat3D = (int)num3D.Value;  
            int seatReg = (int)numReg.Value;
            int costDolby;
            int cost3D;
            int costReg;
            int totalCost = 0;
            int movieIndex;
            int intEnterID;


            enteredID = txtbxMovieID.Text.Trim();
            if (string.IsNullOrEmpty(enteredID))
            {
                MessageBox.Show("ERROR: Please input a movie ID listed from the right");
                return;
            }

            

            if (!int.TryParse(enteredID, out  intEnterID)) // Ensures valid integer input
            {
                MessageBox.Show("ERROR: Movie ID must be a valid number.");
                return;
            }

            movieIndex = intEnterID - 1;
            resultMessage = $"Confirm Booking for {movies[movieIndex, 1]}\n\n";

            int[] seatPrices = new int[3] { 15, 20, 25 };



            if (seatDolby == 0 && seatReg == 0 && seat3D == 0)
            {
                MessageBox.Show("Please choose how many seat you would like");
            }
            else
            {
               
                if (seatDolby > 0)
                {
                    costDolby = seatDolby * seatPrices[2];
                    resultMessage += $"DOLBY: {seatDolby,9} Tickets at ${seatPrices[2]} each = ${costDolby}\n\n";
                    totalCost += costDolby;
                }

                if (seat3D > 0)
                {
                    cost3D = seat3D * seatPrices[1];
                    resultMessage += $"      3D:{seat3D,10} Tickets at ${seatPrices[1]} each = ${cost3D}\n\n";
                    totalCost += cost3D;
                }

                if (seatReg > 0)
                {
                    costReg = seatReg * seatPrices[0];
                    resultMessage += $"Regular:{seatReg,8} Tickets at ${seatPrices[0]} each = ${costReg}\n\n";
                    totalCost += costReg;
                }

                resultMessage += $"                     Total cost: ${totalCost}\n\n Do you want to proceed with this purchase?";

                DialogResult confirmResults = MessageBox.Show(resultMessage, "Confirm Booking", MessageBoxButtons.OKCancel);

                if (confirmResults == DialogResult.OK)
                {

                    formShoppingCart ShoppingCartform = new formShoppingCart(intEnterID, seatDolby, seat3D, seatReg, totalCost, username1);
                    ShoppingCartform.Show();
                    this.Hide();

                }
                else 
                {

                    MessageBox.Show("Booking was cancelled.");
                }
            }

           

           
        }
    }

}
