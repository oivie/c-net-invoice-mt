namespace c_net_invoice_mt
{
    partial class Form1
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
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.lblProdTotal = new System.Windows.Forms.Label();
            this.lbDiscountAmount = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lbTax = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(314, 61);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(200, 31);
            this.txtProductTotal.TabIndex = 0;
            // 
            // lblProdTotal
            // 
            this.lblProdTotal.AutoSize = true;
            this.lblProdTotal.Location = new System.Drawing.Point(75, 67);
            this.lblProdTotal.Name = "lblProdTotal";
            this.lblProdTotal.Size = new System.Drawing.Size(140, 25);
            this.lblProdTotal.TabIndex = 1;
            this.lblProdTotal.Text = "Product Total";
            // 
            // lbDiscountAmount
            // 
            this.lbDiscountAmount.AutoSize = true;
            this.lbDiscountAmount.Location = new System.Drawing.Point(80, 124);
            this.lbDiscountAmount.Name = "lbDiscountAmount";
            this.lbDiscountAmount.Size = new System.Drawing.Size(175, 25);
            this.lbDiscountAmount.TabIndex = 3;
            this.lbDiscountAmount.Text = "Discount Amount";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(314, 118);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(200, 31);
            this.txtDiscountAmount.TabIndex = 2;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(80, 178);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(91, 25);
            this.lbSubtotal.TabIndex = 5;
            this.lbSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(314, 172);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(200, 31);
            this.txtSubtotal.TabIndex = 4;
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Location = new System.Drawing.Point(80, 238);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(111, 25);
            this.lbTax.TabIndex = 7;
            this.lbTax.Text = "Tax(7.5%)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Location = new System.Drawing.Point(314, 292);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 31);
            this.txtTotal.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(80, 398);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 49);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 49);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePercent
            // 
            this.btnChangePercent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnChangePercent.Location = new System.Drawing.Point(554, 238);
            this.btnChangePercent.Name = "btnChangePercent";
            this.btnChangePercent.Size = new System.Drawing.Size(302, 36);
            this.btnChangePercent.TabIndex = 12;
            this.btnChangePercent.Text = "Change Percent";
            this.btnChangePercent.UseVisualStyleBackColor = false;
            this.btnChangePercent.Click += new System.EventHandler(this.btnChangePercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 557);
            this.Controls.Add(this.btnChangePercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lbDiscountAmount);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.lblProdTotal);
            this.Controls.Add(this.txtProductTotal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label lblProdTotal;
        private System.Windows.Forms.Label lbDiscountAmount;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangePercent;
    }
}

