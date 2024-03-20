using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        int score = 0;
        int initialScore = 0;
        int scoreCount = 0;
        int average = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt16(txtScore.Text);
            ++scoreCount;
            initialScore += score;
            average = initialScore / scoreCount;

            txtScoreInitial.Text = initialScore.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = average.ToString();

            txtScore.Focus();
        }
    }
}
