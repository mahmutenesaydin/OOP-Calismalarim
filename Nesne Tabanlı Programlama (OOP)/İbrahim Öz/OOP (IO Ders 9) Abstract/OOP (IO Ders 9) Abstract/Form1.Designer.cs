namespace OOP__IO_Ders_9__Abstract
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
            this.btnGitar = new System.Windows.Forms.Button();
            this.btnBateri = new System.Windows.Forms.Button();
            this.btnKeman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGitar
            // 
            this.btnGitar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGitar.Location = new System.Drawing.Point(56, 76);
            this.btnGitar.Name = "btnGitar";
            this.btnGitar.Size = new System.Drawing.Size(132, 33);
            this.btnGitar.TabIndex = 0;
            this.btnGitar.Text = "Gitar Çal";
            this.btnGitar.UseVisualStyleBackColor = false;
            this.btnGitar.Click += new System.EventHandler(this.btnGitar_Click);
            // 
            // btnBateri
            // 
            this.btnBateri.BackColor = System.Drawing.SystemColors.Control;
            this.btnBateri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBateri.Location = new System.Drawing.Point(56, 127);
            this.btnBateri.Name = "btnBateri";
            this.btnBateri.Size = new System.Drawing.Size(132, 33);
            this.btnBateri.TabIndex = 0;
            this.btnBateri.Text = "Bateri Çal";
            this.btnBateri.UseVisualStyleBackColor = false;
            this.btnBateri.Click += new System.EventHandler(this.btnBateri_Click);
            // 
            // btnKeman
            // 
            this.btnKeman.BackColor = System.Drawing.SystemColors.Control;
            this.btnKeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeman.Location = new System.Drawing.Point(56, 178);
            this.btnKeman.Name = "btnKeman";
            this.btnKeman.Size = new System.Drawing.Size(132, 33);
            this.btnKeman.TabIndex = 0;
            this.btnKeman.Text = "Keman Çal";
            this.btnKeman.UseVisualStyleBackColor = false;
            this.btnKeman.Click += new System.EventHandler(this.btnKeman_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(43, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müzik Aleti Çal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(507, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKeman);
            this.Controls.Add(this.btnBateri);
            this.Controls.Add(this.btnGitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGitar;
        private System.Windows.Forms.Button btnBateri;
        private System.Windows.Forms.Button btnKeman;
        private System.Windows.Forms.Button button1;
    }
}

