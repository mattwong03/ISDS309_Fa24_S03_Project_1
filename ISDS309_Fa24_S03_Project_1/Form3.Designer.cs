namespace ISDS309_Fa24_S03_Project_1
{
    partial class formMovieTickets
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
            lblMovieList = new Label();
            lblMovieID = new Label();
            txtbxMovieID = new TextBox();
            btnMovieID = new Button();
            lblMovieName = new Label();
            lblGenre = new Label();
            lblIMDbRating = new Label();
            lblReleaseDate = new Label();
            lblMovieTitle = new Label();
            lblMovieGenre = new Label();
            lblMovieIMDb = new Label();
            lblMovieReleaseDate = new Label();
            lblMovieDisplay = new Label();
            lblMovieIDList = new Label();
            label5 = new Label();
            lblSeatDolby = new Label();
            lblSeat3D = new Label();
            lblSeatReg = new Label();
            numDolby = new NumericUpDown();
            num3D = new NumericUpDown();
            numReg = new NumericUpDown();
            btnBookTicket = new Button();
            lblMovieTypes = new Label();
            ((System.ComponentModel.ISupportInitialize)numDolby).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num3D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReg).BeginInit();
            SuspendLayout();
            // 
            // lblMovieList
            // 
            lblMovieList.AutoSize = true;
            lblMovieList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieList.Location = new Point(235, 34);
            lblMovieList.Name = "lblMovieList";
            lblMovieList.Size = new Size(232, 50);
            lblMovieList.TabIndex = 0;
            lblMovieList.Text = "Please Input Movie ID To\r\n      See Description";
            // 
            // lblMovieID
            // 
            lblMovieID.AutoSize = true;
            lblMovieID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieID.Location = new Point(195, 101);
            lblMovieID.Name = "lblMovieID";
            lblMovieID.Size = new Size(75, 21);
            lblMovieID.TabIndex = 1;
            lblMovieID.Text = "MovieID";
            // 
            // txtbxMovieID
            // 
            txtbxMovieID.Location = new Point(283, 102);
            txtbxMovieID.Name = "txtbxMovieID";
            txtbxMovieID.Size = new Size(100, 23);
            txtbxMovieID.TabIndex = 2;
            // 
            // btnMovieID
            // 
            btnMovieID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovieID.Location = new Point(412, 101);
            btnMovieID.Name = "btnMovieID";
            btnMovieID.Size = new Size(87, 23);
            btnMovieID.TabIndex = 3;
            btnMovieID.Text = "Confirm";
            btnMovieID.UseVisualStyleBackColor = true;
            btnMovieID.Click += btnMovieID_Click;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMovieName.Location = new Point(218, 176);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(102, 20);
            lblMovieName.TabIndex = 4;
            lblMovieName.Text = "Movie Name:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblGenre.Location = new Point(264, 218);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 20);
            lblGenre.TabIndex = 5;
            lblGenre.Text = "Genre:";
            // 
            // lblIMDbRating
            // 
            lblIMDbRating.AutoSize = true;
            lblIMDbRating.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblIMDbRating.Location = new Point(217, 255);
            lblIMDbRating.Name = "lblIMDbRating";
            lblIMDbRating.Size = new Size(102, 20);
            lblIMDbRating.TabIndex = 6;
            lblIMDbRating.Text = "IMDb Rating:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblReleaseDate.Location = new Point(217, 292);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(103, 20);
            lblReleaseDate.TabIndex = 7;
            lblReleaseDate.Text = "Release Date:";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new Font("Segoe UI", 11.25F);
            lblMovieTitle.Location = new Point(325, 176);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(0, 20);
            lblMovieTitle.TabIndex = 8;
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Font = new Font("Segoe UI", 11.25F);
            lblMovieGenre.Location = new Point(325, 218);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(0, 20);
            lblMovieGenre.TabIndex = 9;
            // 
            // lblMovieIMDb
            // 
            lblMovieIMDb.AutoSize = true;
            lblMovieIMDb.Font = new Font("Segoe UI", 11.25F);
            lblMovieIMDb.Location = new Point(325, 255);
            lblMovieIMDb.Name = "lblMovieIMDb";
            lblMovieIMDb.Size = new Size(0, 20);
            lblMovieIMDb.TabIndex = 10;
            // 
            // lblMovieReleaseDate
            // 
            lblMovieReleaseDate.AutoSize = true;
            lblMovieReleaseDate.Font = new Font("Segoe UI", 11.25F);
            lblMovieReleaseDate.Location = new Point(325, 292);
            lblMovieReleaseDate.Name = "lblMovieReleaseDate";
            lblMovieReleaseDate.Size = new Size(0, 20);
            lblMovieReleaseDate.TabIndex = 11;
            // 
            // lblMovieDisplay
            // 
            lblMovieDisplay.AutoSize = true;
            lblMovieDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDisplay.Location = new Point(1, 9);
            lblMovieDisplay.Name = "lblMovieDisplay";
            lblMovieDisplay.Size = new Size(160, 75);
            lblMovieDisplay.TabIndex = 12;
            lblMovieDisplay.Text = "Available Movies\r\n\r\n  ID    Name";
            // 
            // lblMovieIDList
            // 
            lblMovieIDList.AutoSize = true;
            lblMovieIDList.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieIDList.Location = new Point(7, 95);
            lblMovieIDList.Name = "lblMovieIDList";
            lblMovieIDList.Size = new Size(30, 180);
            lblMovieIDList.TabIndex = 13;
            lblMovieIDList.Text = "[1]\r\n\r\n[2]\r\n\r\n[3]\r\n\r\n[4]\r\n\r\n[5]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(46, 95);
            label5.Name = "label5";
            label5.Size = new Size(104, 180);
            label5.TabIndex = 14;
            label5.Text = "Avatar 2\r\n\r\nOppenheimer\r\n\r\nBarbie\r\n\r\nShrek\r\n\r\nCroods";
            // 
            // lblSeatDolby
            // 
            lblSeatDolby.AutoSize = true;
            lblSeatDolby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatDolby.Location = new Point(656, 63);
            lblSeatDolby.Name = "lblSeatDolby";
            lblSeatDolby.Size = new Size(62, 21);
            lblSeatDolby.TabIndex = 15;
            lblSeatDolby.Text = "DOLBY";
            // 
            // lblSeat3D
            // 
            lblSeat3D.AutoSize = true;
            lblSeat3D.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeat3D.Location = new Point(672, 139);
            lblSeat3D.Name = "lblSeat3D";
            lblSeat3D.Size = new Size(31, 21);
            lblSeat3D.TabIndex = 16;
            lblSeat3D.Text = "3D";
            // 
            // lblSeatReg
            // 
            lblSeatReg.AutoSize = true;
            lblSeatReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatReg.Location = new Point(649, 218);
            lblSeatReg.Name = "lblSeatReg";
            lblSeatReg.Size = new Size(69, 21);
            lblSeatReg.TabIndex = 17;
            lblSeatReg.Text = "Regular";
            // 
            // numDolby
            // 
            numDolby.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDolby.Location = new Point(621, 99);
            numDolby.Name = "numDolby";
            numDolby.Size = new Size(120, 23);
            numDolby.TabIndex = 18;
            // 
            // num3D
            // 
            num3D.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3D.Location = new Point(621, 173);
            num3D.Name = "num3D";
            num3D.Size = new Size(120, 23);
            num3D.TabIndex = 19;
            // 
            // numReg
            // 
            numReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numReg.Location = new Point(621, 255);
            numReg.Name = "numReg";
            numReg.Size = new Size(120, 23);
            numReg.TabIndex = 20;
            // 
            // btnBookTicket
            // 
            btnBookTicket.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookTicket.Location = new Point(643, 308);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(75, 27);
            btnBookTicket.TabIndex = 21;
            btnBookTicket.Text = "Book";
            btnBookTicket.UseVisualStyleBackColor = true;
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // lblMovieTypes
            // 
            lblMovieTypes.AutoSize = true;
            lblMovieTypes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMovieTypes.Location = new Point(621, 23);
            lblMovieTypes.Name = "lblMovieTypes";
            lblMovieTypes.Size = new Size(136, 21);
            lblMovieTypes.TabIndex = 22;
            lblMovieTypes.Text = "Buy Tickets Here";
            // 
            // formMovieTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMovieTypes);
            Controls.Add(btnBookTicket);
            Controls.Add(numReg);
            Controls.Add(num3D);
            Controls.Add(numDolby);
            Controls.Add(lblSeatReg);
            Controls.Add(lblSeat3D);
            Controls.Add(lblSeatDolby);
            Controls.Add(label5);
            Controls.Add(lblMovieIDList);
            Controls.Add(lblMovieDisplay);
            Controls.Add(lblMovieReleaseDate);
            Controls.Add(lblMovieIMDb);
            Controls.Add(lblMovieGenre);
            Controls.Add(lblMovieTitle);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblIMDbRating);
            Controls.Add(lblGenre);
            Controls.Add(lblMovieName);
            Controls.Add(btnMovieID);
            Controls.Add(txtbxMovieID);
            Controls.Add(lblMovieID);
            Controls.Add(lblMovieList);
            Name = "formMovieTickets";
            Text = "Movie Tickets";
            ((System.ComponentModel.ISupportInitialize)numDolby).EndInit();
            ((System.ComponentModel.ISupportInitialize)num3D).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieList;
        private Label lblMovieID;
        private TextBox txtbxMovieID;
        private Button btnMovieID;
        private Label lblMovieName;
        private Label lblGenre;
        private Label lblIMDbRating;
        private Label lblReleaseDate;
        private Label lblMovieTitle;
        private Label lblMovieGenre;
        private Label lblMovieIMDb;
        private Label lblMovieReleaseDate;
        private Label lblMovieDisplay;
        private Label lblMovieIDList;
        private Label label5;
        private Label lblSeatDolby;
        private Label lblSeat3D;
        private Label lblSeatReg;
        private NumericUpDown numDolby;
        private NumericUpDown num3D;
        private NumericUpDown numReg;
        private Button btnBookTicket;
        private Label lblMovieTypes;
    }
}