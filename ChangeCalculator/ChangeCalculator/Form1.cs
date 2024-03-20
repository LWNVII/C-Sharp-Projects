using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class ChangeCalculator : Form
    {
        

        public ChangeCalculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            int quarters = input / 25;
            int pennies = input % 25;
            txtQuarters.Text = quarters.ToString();

            int dimes = pennies / 10;
            pennies = pennies % 10;
            txtDimes.Text = dimes.ToString();

            int nickels = pennies / 5;
            pennies = pennies % 5;
            txtNickels.Text = nickels.ToString();

            txtPennies.Text = pennies.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
