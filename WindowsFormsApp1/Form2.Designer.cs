namespace WindowsFormsApp1
{
    partial class frmRadio
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoYellow2 = new System.Windows.Forms.RadioButton();
            this.rdoBlue2 = new System.Windows.Forms.RadioButton();
            this.rdoGreen2 = new System.Windows.Forms.RadioButton();
            this.rdoRed2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(275, 387);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 39);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(147, 29);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(88, 39);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(44, 165);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(55, 21);
            this.rdoRed.TabIndex = 2;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(44, 219);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(69, 21);
            this.rdoGreen.TabIndex = 3;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(44, 263);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(57, 21);
            this.rdoBlue.TabIndex = 4;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(44, 306);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(69, 21);
            this.rdoYellow.TabIndex = 5;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYellow2);
            this.groupBox1.Controls.Add(this.rdoBlue2);
            this.groupBox1.Controls.Add(this.rdoGreen2);
            this.groupBox1.Controls.Add(this.rdoRed2);
            this.groupBox1.Location = new System.Drawing.Point(177, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // rdoYellow2
            // 
            this.rdoYellow2.AutoSize = true;
            this.rdoYellow2.Location = new System.Drawing.Point(21, 176);
            this.rdoYellow2.Name = "rdoYellow2";
            this.rdoYellow2.Size = new System.Drawing.Size(69, 21);
            this.rdoYellow2.TabIndex = 9;
            this.rdoYellow2.TabStop = true;
            this.rdoYellow2.Text = "Yellow";
            this.rdoYellow2.UseVisualStyleBackColor = true;
            this.rdoYellow2.CheckedChanged += new System.EventHandler(this.rdoYellow2_CheckedChanged);
            // 
            // rdoBlue2
            // 
            this.rdoBlue2.AutoSize = true;
            this.rdoBlue2.Location = new System.Drawing.Point(21, 133);
            this.rdoBlue2.Name = "rdoBlue2";
            this.rdoBlue2.Size = new System.Drawing.Size(57, 21);
            this.rdoBlue2.TabIndex = 8;
            this.rdoBlue2.TabStop = true;
            this.rdoBlue2.Text = "Blue";
            this.rdoBlue2.UseVisualStyleBackColor = true;
            this.rdoBlue2.CheckedChanged += new System.EventHandler(this.rdoBlue2_CheckedChanged);
            // 
            // rdoGreen2
            // 
            this.rdoGreen2.AutoSize = true;
            this.rdoGreen2.Location = new System.Drawing.Point(21, 89);
            this.rdoGreen2.Name = "rdoGreen2";
            this.rdoGreen2.Size = new System.Drawing.Size(69, 21);
            this.rdoGreen2.TabIndex = 7;
            this.rdoGreen2.TabStop = true;
            this.rdoGreen2.Text = "Green";
            this.rdoGreen2.UseVisualStyleBackColor = true;
            this.rdoGreen2.CheckedChanged += new System.EventHandler(this.rdoGreen2_CheckedChanged);
            // 
            // rdoRed2
            // 
            this.rdoRed2.AutoSize = true;
            this.rdoRed2.Location = new System.Drawing.Point(21, 35);
            this.rdoRed2.Name = "rdoRed2";
            this.rdoRed2.Size = new System.Drawing.Size(55, 21);
            this.rdoRed2.TabIndex = 6;
            this.rdoRed2.TabStop = true;
            this.rdoRed2.Text = "Red";
            this.rdoRed2.UseVisualStyleBackColor = true;
            this.rdoRed2.CheckedChanged += new System.EventHandler(this.rdoRed2_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoYellow);
            this.Controls.Add(this.rdoBlue);
            this.Controls.Add(this.rdoGreen);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBack);
            this.Name = "frmRadio";
            this.Text = "Radio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoYellow2;
        private System.Windows.Forms.RadioButton rdoBlue2;
        private System.Windows.Forms.RadioButton rdoGreen2;
        private System.Windows.Forms.RadioButton rdoRed2;
    }
}