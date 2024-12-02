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
    
    public partial class formReceipt : Form
    {
       
        int intEnterID;
        int seatDolby;
        int seatReg;
        int seats3D;
        int totalCost;
        string username1;

        public formReceipt(int intEnterID, int seatDolby, int seats3D, int seatReg, int totalCost, string username1)
        {
            InitializeComponent();

            //int intEnterID, int seatDolby, int seats3D, int seatReg, int totalCost, string username1;
            lblReceiptMovieResult.Text = intEnterID.ToString();
            lblReceiptSeatResult.Text = seatDolby.ToString() + seats3D.ToString() + seatReg.ToString();
            //lblReceiptSeatTypeResult.Text = 
            lblReceiptTotalResult.Text = totalCost.ToString();


        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            formReceipt Receiptform = new formReceipt(username1);
            Receiptform.Show();
            this.Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            formReceipt Receiptform = new formReceipt(username1); 
            Receiptform.Show();
            this.Close();
        }

        
    }
}
