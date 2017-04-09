namespace _28_CheckAccountBalance
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
            this.Options = new System.Windows.Forms.GroupBox();
            this.rdDeposit = new System.Windows.Forms.RadioButton();
            this.rdCheck = new System.Windows.Forms.RadioButton();
            this.rdServiceCharge = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.Controls.Add(this.rdServiceCharge);
            this.Options.Controls.Add(this.rdCheck);
            this.Options.Controls.Add(this.rdDeposit);
            this.Options.Location = new System.Drawing.Point(29, 26);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(207, 128);
            this.Options.TabIndex = 0;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // rdDeposit
            // 
            this.rdDeposit.AutoSize = true;
            this.rdDeposit.Location = new System.Drawing.Point(23, 33);
            this.rdDeposit.Name = "rdDeposit";
            this.rdDeposit.Size = new System.Drawing.Size(61, 17);
            this.rdDeposit.TabIndex = 0;
            this.rdDeposit.TabStop = true;
            this.rdDeposit.Text = "Deposit";
            this.rdDeposit.UseVisualStyleBackColor = true;
            // 
            // rdCheck
            // 
            this.rdCheck.AutoSize = true;
            this.rdCheck.Location = new System.Drawing.Point(23, 66);
            this.rdCheck.Name = "rdCheck";
            this.rdCheck.Size = new System.Drawing.Size(56, 17);
            this.rdCheck.TabIndex = 1;
            this.rdCheck.TabStop = true;
            this.rdCheck.Text = "Check";
            this.rdCheck.UseVisualStyleBackColor = true;
            // 
            // rdServiceCharge
            // 
            this.rdServiceCharge.AutoSize = true;
            this.rdServiceCharge.Location = new System.Drawing.Point(23, 97);
            this.rdServiceCharge.Name = "rdServiceCharge";
            this.rdServiceCharge.Size = new System.Drawing.Size(98, 17);
            this.rdServiceCharge.TabIndex = 2;
            this.rdServiceCharge.TabStop = true;
            this.rdServiceCharge.Text = "Service Charge";
            this.rdServiceCharge.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Account Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(402, 136);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(13, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "0";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(410, 34);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(119, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 34);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(289, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(416, 187);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(113, 34);
            this.btnSummary.TabIndex = 8;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 246);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.RadioButton rdServiceCharge;
        private System.Windows.Forms.RadioButton rdCheck;
        private System.Windows.Forms.RadioButton rdDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSummary;
    }
}

