namespace WindowsFormsApp1
{
    partial class frmrandom
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
            this.BtnGenerateRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerateRandom
            // 
            this.BtnGenerateRandom.Location = new System.Drawing.Point(35, 27);
            this.BtnGenerateRandom.Name = "BtnGenerateRandom";
            this.BtnGenerateRandom.Size = new System.Drawing.Size(175, 52);
            this.BtnGenerateRandom.TabIndex = 0;
            this.BtnGenerateRandom.Text = "Generate Random Color";
            this.BtnGenerateRandom.UseVisualStyleBackColor = true;
            this.BtnGenerateRandom.Click += new System.EventHandler(this.BtnGenerateRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "R-G-B";
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.Location = new System.Drawing.Point(35, 186);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(116, 49);
            this.btnRandomNumber.TabIndex = 2;
            this.btnRandomNumber.Text = "Random Number";
            this.btnRandomNumber.UseVisualStyleBackColor = true;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(135, 276);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmrandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerateRandom);
            this.Name = "frmrandom";
            this.Text = "random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Button btnback;
    }
}