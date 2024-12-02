namespace ISDS309_Fa24_S03_Project_1
{
    partial class formMovieLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMovieLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtbxUsername = new TextBox();
            txtbxPassword = new TextBox();
            btnLogin = new Button();
            lblMessageLogin = new Label();
            SuspendLayout();
            // 
            // lblMovieLogin
            // 
            lblMovieLogin.AutoSize = true;
            lblMovieLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovieLogin.Location = new Point(246, 46);
            lblMovieLogin.Name = "lblMovieLogin";
            lblMovieLogin.Size = new Size(91, 20);
            lblMovieLogin.TabIndex = 0;
            lblMovieLogin.Text = "Movie Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(169, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(169, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtbxUsername
            // 
            txtbxUsername.Location = new Point(283, 112);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(137, 23);
            txtbxUsername.TabIndex = 3;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Location = new Point(283, 193);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(137, 23);
            txtbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(415, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessageLogin
            // 
            lblMessageLogin.AutoSize = true;
            lblMessageLogin.Location = new Point(294, 232);
            lblMessageLogin.Name = "lblMessageLogin";
            lblMessageLogin.Size = new Size(0, 15);
            lblMessageLogin.TabIndex = 6;
            // 
            // formMovieLog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(650, 363);
            Controls.Add(lblMessageLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtbxPassword);
            Controls.Add(txtbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblMovieLogin);
            Name = "formMovieLog";
            Text = "formMovieLog";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Button btnLogin;
        private Label lblMessageLogin;
    }
}
