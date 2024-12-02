namespace ISDS309_Fa24_S03_Project_1
{
    partial class formReceipt
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
            lblReceipt = new Label();
            lblReceiptMovie = new Label();
            lblReceiptSeat = new Label();
            lblReceiptTotal = new Label();
            lblReceiptSeatType = new Label();
            lblReceiptMovieResult = new Label();
            lblReceiptSeatResult = new Label();
            lblReceiptSeatTypeResult = new Label();
            lblReceiptTotalResult = new Label();
            SuspendLayout();
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceipt.Location = new Point(368, 62);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(67, 21);
            lblReceipt.TabIndex = 0;
            lblReceipt.Text = "Receipt";
            // 
            // lblReceiptMovie
            // 
            lblReceiptMovie.AutoSize = true;
            lblReceiptMovie.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceiptMovie.Location = new Point(94, 140);
            lblReceiptMovie.Name = "lblReceiptMovie";
            lblReceiptMovie.Size = new Size(112, 21);
            lblReceiptMovie.TabIndex = 1;
            lblReceiptMovie.Text = "Movie Name:";
            // 
            // lblReceiptSeat
            // 
            lblReceiptSeat.AutoSize = true;
            lblReceiptSeat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceiptSeat.Location = new Point(94, 214);
            lblReceiptSeat.Name = "lblReceiptSeat";
            lblReceiptSeat.Size = new Size(139, 21);
            lblReceiptSeat.TabIndex = 2;
            lblReceiptSeat.Text = "Number of seats:";
            // 
            // lblReceiptTotal
            // 
            lblReceiptTotal.AutoSize = true;
            lblReceiptTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceiptTotal.Location = new Point(95, 368);
            lblReceiptTotal.Name = "lblReceiptTotal";
            lblReceiptTotal.Size = new Size(111, 21);
            lblReceiptTotal.TabIndex = 3;
            lblReceiptTotal.Text = "Total Price: $ ";
            // 
            // lblReceiptSeatType
            // 
            lblReceiptSeatType.AutoSize = true;
            lblReceiptSeatType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceiptSeatType.Location = new Point(95, 292);
            lblReceiptSeatType.Name = "lblReceiptSeatType";
            lblReceiptSeatType.Size = new Size(116, 21);
            lblReceiptSeatType.TabIndex = 4;
            lblReceiptSeatType.Text = "Type of seats: ";
            // 
            // lblReceiptMovieResult
            // 
            lblReceiptMovieResult.AutoSize = true;
            lblReceiptMovieResult.Location = new Point(212, 146);
            lblReceiptMovieResult.Name = "lblReceiptMovieResult";
            lblReceiptMovieResult.Size = new Size(0, 15);
            lblReceiptMovieResult.TabIndex = 5;
            // 
            // lblReceiptSeatResult
            // 
            lblReceiptSeatResult.AutoSize = true;
            lblReceiptSeatResult.Location = new Point(239, 219);
            lblReceiptSeatResult.Name = "lblReceiptSeatResult";
            lblReceiptSeatResult.Size = new Size(0, 15);
            lblReceiptSeatResult.TabIndex = 6;
            // 
            // lblReceiptSeatTypeResult
            // 
            lblReceiptSeatTypeResult.AutoSize = true;
            lblReceiptSeatTypeResult.Location = new Point(219, 297);
            lblReceiptSeatTypeResult.Name = "lblReceiptSeatTypeResult";
            lblReceiptSeatTypeResult.Size = new Size(0, 15);
            lblReceiptSeatTypeResult.TabIndex = 7;
            // 
            // lblReceiptTotalResult
            // 
            lblReceiptTotalResult.AutoSize = true;
            lblReceiptTotalResult.Location = new Point(212, 373);
            lblReceiptTotalResult.Name = "lblReceiptTotalResult";
            lblReceiptTotalResult.Size = new Size(0, 15);
            lblReceiptTotalResult.TabIndex = 8;
            // 
            // formReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblReceiptTotalResult);
            Controls.Add(lblReceiptSeatTypeResult);
            Controls.Add(lblReceiptSeatResult);
            Controls.Add(lblReceiptMovieResult);
            Controls.Add(lblReceiptSeatType);
            Controls.Add(lblReceiptTotal);
            Controls.Add(lblReceiptSeat);
            Controls.Add(lblReceiptMovie);
            Controls.Add(lblReceipt);
            Name = "formReceipt";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReceipt;
        private Label lblReceiptMovie;
        private Label lblReceiptSeat;
        private Label lblReceiptTotal;
        private Label lblReceiptSeatType;
        private Label lblReceiptMovieResult;
        private Label lblReceiptSeatResult;
        private Label lblReceiptSeatTypeResult;
        private Label lblReceiptTotalResult;
    }
}