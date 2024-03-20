using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtLength, "Length") && IsDecimal(txtLength, "Length"))
            {
                // Assigns the value in the text box txtLength to a variable
                decimal lengthFrom = Convert.ToDecimal(txtLength.Text);

                // Based on what measurement conversion the user selects, performs appropriate calculation.
                if (cboConversions.SelectedIndex == 0)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[0, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
                else if (cboConversions.SelectedIndex == 1)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[1, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
                else if (cboConversions.SelectedIndex == 2)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[2, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
                else if (cboConversions.SelectedIndex == 3)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[3, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
                else if (cboConversions.SelectedIndex == 4)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[4, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
                else if (cboConversions.SelectedIndex == 5)
                {
                    lengthFrom = lengthFrom * Convert.ToDecimal(conversionTable[5, 3]);
                    lblCalculatedLength.Text = lengthFrom.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < conversionTable.GetLength (0); i++)
            {
                cboConversions.Items.Add(conversionTable[i, 0]);
                cboConversions.SelectedIndex = 0;
            }
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConversions.SelectedIndex == 0) 
            {
                lblFromLength.Text = conversionTable[0, 1].ToString();
                lblToLength.Text = conversionTable[0, 2].ToString();
            }
            else if (cboConversions.SelectedIndex == 1)
            {
                lblFromLength.Text = conversionTable[1, 1].ToString();
                lblToLength.Text = conversionTable[1, 2].ToString();
            }
            else if (cboConversions.SelectedIndex == 2)
            {
                lblFromLength.Text = conversionTable[2, 1].ToString();
                lblToLength.Text = conversionTable[2, 2].ToString();
            }
            else if (cboConversions.SelectedIndex == 3)
            {
                lblFromLength.Text = conversionTable[3, 1].ToString();
                lblToLength.Text = conversionTable[3, 2].ToString();
            }
            else if (cboConversions.SelectedIndex == 4)
            {
                lblFromLength.Text = conversionTable[4, 1].ToString();
                lblToLength.Text = conversionTable[4, 2].ToString();
            }
            else if (cboConversions.SelectedIndex == 5)
            {
                lblFromLength.Text = conversionTable[5, 1].ToString();
                lblToLength.Text = conversionTable[5, 2].ToString();
            }
            txtLength.Focus();
            lblCalculatedLength.Text = "";
        }

        private void lblFromLength_Click(object sender, EventArgs e)
        {

        }
    }
}