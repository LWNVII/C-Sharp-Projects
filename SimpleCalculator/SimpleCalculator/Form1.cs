using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class simpleCalculator : Form
    {
        public simpleCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

            decimal result = calculateResult(operand1, operator1, operand2);

            txtResult.Text = Convert.ToString(result);
        }

        private decimal calculateResult(decimal operand1, String operator1, decimal operand2)
        {

            decimal result = 0;

            if (operator1 == "/")
            {
                result = operand1 / operand2;
            }
            else if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }

            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}

