using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ISDS309_Fa24_S03_Project_1
{
    public partial class formMainMenu : Form
    {
        private string nameUser;
        private string username1;
        public formMainMenu(string nameUser, string username1)
        {
            InitializeComponent();
            this.nameUser = nameUser;
            this.username1 = username1;

        }

        //display welcome message
        private void formMainMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + nameUser + "!";
        }

        //if buy ticket button is clicked, it moves form to buying form
        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            formMovieTickets MovieTicketsform = new formMovieTickets(username1);
            MovieTicketsform.Show();
            this.Close();
        }

        //if log out button is clicked, it logs out and restarts the process
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            formMovieLog MovieLogform = new formMovieLog();
            MovieLogform.Show();
            this.Close();
        }
    }
}
