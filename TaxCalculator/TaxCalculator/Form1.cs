using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class incomeTaxCalculator : Form
    {
        public incomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal income = Convert.ToDecimal(txtTaxableIncome.Text);
            decimal amountOwed = CalculateTax(income);

            txtTaxOwed.Text = amountOwed.ToString();
        }

        private decimal CalculateTax(decimal income)
        {
            // declaring variables for user input and for the final output
            decimal amountOwed = 0m;

            // control structure beginning to perform correct calculations within each tax brackets
            if (income <= 9875)
            {
                // if amount owed is less than or equal to $9225.00 then amount owed equals 10% of income
                amountOwed = (int)(income * .10m);
            }
            else if (income > 9875 && income <= 40125)
            {
                // if amount owed is between %9226.00 and $37450.00 then income is taxed prior percent up till break point,
                // and the remainder is taxed 12%
                amountOwed = 987.5m + (int)((income - 9875) * .12m);
            }
            else if (income > 40125 && income <= 85525)
            {
                amountOwed = 4012.5m + (int)((income - 40125) * .22m);
            }
            else if (income > 85526 && income <= 163301)
            {
                amountOwed = 8552.5m + (int)((income - 85525) * .24m);
            }
            else if (income > 163301 && income <= 207351)
            {
                amountOwed = 16330.1m + (int)((income - 163301) * .32m);
            }
            else if (income > 207351 && income <= 518400)
            {
                amountOwed = 20735.1m + (int)((income - 207351) * .35m);
            }
            else if (income > 518400)
            {
                amountOwed = 51840.0m + (int)((income - 518400) * .37m);
            }

            return amountOwed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaxableIncome_TextChanged(object sender, EventArgs e)
        {
            txtTaxOwed.Text = "";
        }
    }
}
