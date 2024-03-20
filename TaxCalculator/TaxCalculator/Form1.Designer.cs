namespace TaxCalculator
{
    partial class incomeTaxCalculator
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
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(37, 31);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(85, 13);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Taxable income:";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(40, 64);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(91, 13);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "Income tax owed:";
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(157, 28);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.txtTaxableIncome.TabIndex = 2;
            this.txtTaxableIncome.TextChanged += new System.EventHandler(this.txtTaxableIncome_TextChanged);
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(157, 61);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtTaxOwed.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 97);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 97);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // incomeTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 154);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "incomeTaxCalculator";
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
    }
}

