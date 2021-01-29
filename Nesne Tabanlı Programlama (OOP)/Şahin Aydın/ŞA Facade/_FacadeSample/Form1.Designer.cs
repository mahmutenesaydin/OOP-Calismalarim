namespace _FacadeSample
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
            this.btnBul = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.ListBox();
            this.lblCredit = new System.Windows.Forms.ListBox();
            this.lblLoan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnUygunmu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(34, 39);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 28);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(160, 39);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(151, 23);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.FormattingEnabled = true;
            this.lblBank.ItemHeight = 16;
            this.lblBank.Location = new System.Drawing.Point(30, 210);
            this.lblBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(98, 228);
            this.lblBank.TabIndex = 2;
            // 
            // lblCredit
            // 
            this.lblCredit.FormattingEnabled = true;
            this.lblCredit.ItemHeight = 16;
            this.lblCredit.Location = new System.Drawing.Point(140, 210);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(109, 228);
            this.lblCredit.TabIndex = 2;
            // 
            // lblLoan
            // 
            this.lblLoan.FormattingEnabled = true;
            this.lblLoan.ItemHeight = 16;
            this.lblLoan.Location = new System.Drawing.Point(265, 210);
            this.lblLoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(100, 228);
            this.lblLoan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(160, 89);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(151, 23);
            this.txtAmount.TabIndex = 1;
            // 
            // btnUygunmu
            // 
            this.btnUygunmu.Location = new System.Drawing.Point(267, 137);
            this.btnUygunmu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUygunmu.Name = "btnUygunmu";
            this.btnUygunmu.Size = new System.Drawing.Size(100, 28);
            this.btnUygunmu.TabIndex = 0;
            this.btnUygunmu.Text = "Uygun mu ?";
            this.btnUygunmu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnUygunmu);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnBul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ListBox lblBank;
        private System.Windows.Forms.ListBox lblCredit;
        private System.Windows.Forms.ListBox lblLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnUygunmu;
    }
}

