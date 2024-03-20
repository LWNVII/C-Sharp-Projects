using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTotals()
        {
            lblSubtotal.Text = "";
            lblSalesTax.Text = "";
            lblOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Lettuce, tomator, and onions";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";
            gbxAddOns.Text = "Add-on items($0.75/each)";
            total = 6.95m;
            ClearAddOns();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
            gbxAddOns.Text = "Add-on items($0.50/each)";
            total = 5.95m;
            ClearAddOns();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";
            gbxAddOns.Text = "Add-on items($0.25/each)";
            total = 4.95m;
            ClearAddOns();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                total += .75m;
            }
            else if (radioButton2.Checked == true)
            {
                total += .50m;
            }
            else if (radioButton3.Checked == true)
            {
                total += .25m;
            }
            ClearTotals();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                total += .75m;
            }
            else if (radioButton2.Checked == true)
            {
                total += .50m;
            }
            else if (radioButton3.Checked == true)
            {
                total += .25m;
            }
            ClearTotals();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                total += .75m;
            }
            else if (radioButton2.Checked == true)
            {
                total += .50m;
            }
            else if (radioButton3.Checked == true)
            {
                total += .25m;
            }
            ClearTotals();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal tax = total * .0775m;
            lblSubtotal.Text = total.ToString();
            lblSalesTax.Text = tax.ToString();
            lblOrderTotal.Text = (total + tax).ToString();
        }
    }
}