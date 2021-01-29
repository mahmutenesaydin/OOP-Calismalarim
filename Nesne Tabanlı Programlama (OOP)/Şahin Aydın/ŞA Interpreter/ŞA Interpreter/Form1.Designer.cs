namespace ŞA_Interpreter
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInterpret = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtRoman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(328, 184);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 63);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInterpret
            // 
            this.btnInterpret.Location = new System.Drawing.Point(133, 184);
            this.btnInterpret.Margin = new System.Windows.Forms.Padding(5);
            this.btnInterpret.Name = "btnInterpret";
            this.btnInterpret.Size = new System.Drawing.Size(185, 63);
            this.btnInterpret.TabIndex = 8;
            this.btnInterpret.Text = "Çevir";
            this.btnInterpret.UseVisualStyleBackColor = true;
            this.btnInterpret.Click += new System.EventHandler(this.btnInterpret_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(133, 115);
            this.txtDecimal.Margin = new System.Windows.Forms.Padding(5);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(377, 27);
            this.txtDecimal.TabIndex = 7;
            // 
            // txtRoman
            // 
            this.txtRoman.Location = new System.Drawing.Point(133, 44);
            this.txtRoman.Margin = new System.Windows.Forms.Padding(5);
            this.txtRoman.Name = "txtRoman";
            this.txtRoman.Size = new System.Drawing.Size(377, 27);
            this.txtRoman.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Onluk karşılığı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Roma sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 284);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInterpret);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtRoman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInterpret;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtRoman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

