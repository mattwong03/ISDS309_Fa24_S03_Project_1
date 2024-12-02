namespace ISDS309_Fa24_S03_Project_1
{
    partial class formMainMenu
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
            lblWelcome = new Label();
            lblBuyTicket = new Label();
            btnBuyTicket = new Button();
            lblCheckReciept = new Label();
            btnReciept = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(227, 152);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 21);
            lblWelcome.TabIndex = 0;
            // 
            // lblBuyTicket
            // 
            lblBuyTicket.AutoSize = true;
            lblBuyTicket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuyTicket.Location = new Point(194, 255);
            lblBuyTicket.Name = "lblBuyTicket";
            lblBuyTicket.Size = new Size(171, 21);
            lblBuyTicket.TabIndex = 1;
            lblBuyTicket.Text = "Buy movie tickets here!";
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.Location = new Point(227, 291);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(100, 23);
            btnBuyTicket.TabIndex = 2;
            btnBuyTicket.Text = "Movie Tickets";
            btnBuyTicket.UseVisualStyleBackColor = true;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // lblCheckReciept
            // 
            lblCheckReciept.AutoSize = true;
            lblCheckReciept.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckReciept.Location = new Point(456, 86);
            lblCheckReciept.Name = "lblCheckReciept";
            lblCheckReciept.Size = new Size(143, 21);
            lblCheckReciept.TabIndex = 3;
            lblCheckReciept.Text = "Check Your Reciept";
            // 
            // btnReciept
            // 
            btnReciept.Location = new Point(478, 119);
            btnReciept.Name = "btnReciept";
            btnReciept.Size = new Size(94, 23);
            btnReciept.TabIndex = 4;
            btnReciept.Text = "Check Reciept";
            btnReciept.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(28, 52);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 28);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // formMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 418);
            Controls.Add(btnLogOut);
            Controls.Add(btnReciept);
            Controls.Add(lblCheckReciept);
            Controls.Add(btnBuyTicket);
            Controls.Add(lblBuyTicket);
            Controls.Add(lblWelcome);
            Name = "formMainMenu";
            Text = "Main Menu";
            Load += formMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblBuyTicket;
        private Button btnBuyTicket;
        private Label lblCheckReciept;
        private Button btnReciept;
        private Button btnLogOut;
    }
}