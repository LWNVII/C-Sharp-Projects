﻿namespace SimpleCalculator
{
    partial class simpleCalculator
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
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(181, 29);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 0;
            this.txtOperand1.TextChanged += new System.EventHandler(this.txtOperand1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operand 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result:";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(181, 72);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(100, 20);
            this.txtOperator.TabIndex = 5;
            this.txtOperator.TextChanged += new System.EventHandler(this.txtOperator_TextChanged);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(181, 114);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 6;
            this.txtOperand2.TextChanged += new System.EventHandler(this.txtOperand2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(181, 162);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // simpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOperand1);
            this.Name = "simpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

