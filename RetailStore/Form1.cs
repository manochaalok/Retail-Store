using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;


namespace RetailStore
{
    public partial class Form1 : Form
    {
        calculateDiscount objcalDiscount = calculateDiscount.CreateInstance();
        CustomerInfo oCustomerInfo = new CustomerInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            oCustomerInfo.GrocAmount = Convert.ToDouble(txtGrocAmount.Text);
            oCustomerInfo.NonGrocAmount = Convert.ToDouble(txtNonGrocAmount.Text);
            oCustomerInfo.PercDiscount = 0;

            if (txtCustomerID.Text != "")
            {
                oCustomerInfo.CustomerId = Convert.ToInt32(txtCustomerID.Text);
                oCustomerInfo.PercDiscount = objcalDiscount.GetPercentageDiscount(txtCustomerID.Text);
                oCustomerInfo = calculateDiscount.getNetAmount(oCustomerInfo);
            }
            lblTotDiscount.Text = "Total discount in %: " + oCustomerInfo.PercDiscount;
            lblNetPayAmount.Text = "Net Payable Amount: " + oCustomerInfo.NetAmount;
            lblCashDiscount.Text = "Total Cash Discount:" + oCustomerInfo.CashDiscount;

        }
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Enter) && e.KeyChar != (char)(Keys.Back) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtGrocAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericDecimalValidation(sender, e);

        }

        private void txtNonGrocAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericDecimalValidation(sender, e);

        }
        public void NumericDecimalValidation(object Sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "." || char.IsControl(e.KeyChar))
            {
                if (((TextBox)Sender).Text.IndexOf(".") != -1 && e.KeyChar.ToString() == ".")
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;
        }

    }
}
