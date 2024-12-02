using Microsoft.VisualBasic.ApplicationServices;

namespace ISDS309_Fa24_S03_Project_1
{
    public partial class formMovieLog : Form
    {
        public formMovieLog()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //assign var to txtbx
            string username1 = txtbxUsername.Text;
            string password = txtbxPassword.Text;
            string nameUser;
            string filePath = "login.txt";

            if (File.Exists(filePath))
            {
                // scans all the text in the file
                string[] lines = File.ReadAllLines(filePath);

                // each line of the file loops
                foreach (string line in lines)
                {
                    // comma splits between the username,password,name and email
                    string[] userInfo = line.Split(',');

                    // makes sure if user and pw matches
                    if (userInfo[0] == username1 && userInfo[1] == password)
                    {
                        // show message if good
                        MessageBox.Show("Login successful! Welcome, " + userInfo[2]);
                        lblMessageLogin.Text = "Login successful!";

                        nameUser = userInfo[2];

                        //moves to mainmenu after logging in successfully
                      
                        formMainMenu mainMenuForm = new formMainMenu(nameUser,username1);
                        mainMenuForm.Show();
                        this.Hide();

                        return;
                    }
                }

                // show message if bad
                lblMessageLogin.Text = "Invalid username or password.";

            }
            else
            {
                MessageBox.Show("Error: login.txt file not found.");
            }
        }

       
    }

}

