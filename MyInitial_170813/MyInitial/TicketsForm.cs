using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;
        decimal discount = 0;
        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);
            
            if (chkDiscount.Checked)
                { mDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (radBack.Checked)
            {
                mSection = 4;
            }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount);
            decimal discount = 0;
            mTicketPrice.calculatePrice();
            if (txtDiscount.Text != "")
            {
                discount = decimal.Parse(txtDiscount.Text);
                
                
            }
            //latest change
            mTicketPrice.AmountDue -= discount;

            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void radBalcony_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = 8.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //cannot have 2 discounts
            chkDiscount.Checked = false;
            discount = 10;

        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            discount = 5;
        }
    }
}
