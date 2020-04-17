namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.Arduino = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnPicturebox = new System.Windows.Forms.Button();
            this.BtnPicturebox2 = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheckbox = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Controls.Add(this.LblPassword);
            this.groupBox1.Controls.Add(this.LblUsername);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(82, 49);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 22);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(82, 21);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 22);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(6, 49);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(69, 17);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(2, 21);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(73, 17);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            this.LblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.Location = new System.Drawing.Point(309, 48);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(173, 28);
            this.BtnRadio.TabIndex = 1;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnABCAnalysis.Location = new System.Drawing.Point(946, 88);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(75, 27);
            this.BtnABCAnalysis.TabIndex = 2;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = true;
            // 
            // BtnJohari
            // 
            this.BtnJohari.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnJohari.Location = new System.Drawing.Point(946, 48);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(75, 31);
            this.BtnJohari.TabIndex = 3;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = true;
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnManufacturingCell.Location = new System.Drawing.Point(667, 194);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(354, 28);
            this.BtnManufacturingCell.TabIndex = 4;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = true;
            // 
            // Arduino
            // 
            this.Arduino.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Arduino.Location = new System.Drawing.Point(829, 88);
            this.Arduino.Name = "Arduino";
            this.Arduino.Size = new System.Drawing.Size(111, 27);
            this.Arduino.TabIndex = 5;
            this.Arduino.Text = "BtnArduino";
            this.Arduino.UseVisualStyleBackColor = true;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRoboticCell.Location = new System.Drawing.Point(829, 49);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(111, 33);
            this.BtnRoboticCell.TabIndex = 6;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = true;
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.Location = new System.Drawing.Point(488, 120);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(173, 28);
            this.BtnRandomCombo.TabIndex = 7;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = true;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRandom.Location = new System.Drawing.Point(667, 88);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(75, 27);
            this.BtnRandom.TabIndex = 8;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnDraw.Location = new System.Drawing.Point(748, 49);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(75, 33);
            this.BtnDraw.TabIndex = 9;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // BtnTalk
            // 
            this.BtnTalk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnTalk.Location = new System.Drawing.Point(748, 88);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(75, 27);
            this.BtnTalk.TabIndex = 10;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            // 
            // BtnTimer
            // 
            this.BtnTimer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnTimer.Location = new System.Drawing.Point(667, 50);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(75, 32);
            this.BtnTimer.TabIndex = 11;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            // 
            // BtnProgress
            // 
            this.BtnProgress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnProgress.Location = new System.Drawing.Point(667, 158);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(156, 28);
            this.BtnProgress.TabIndex = 12;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = true;
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnGroupieApp.Location = new System.Drawing.Point(667, 121);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(156, 31);
            this.BtnGroupieApp.TabIndex = 13;
            this.BtnGroupieApp.Text = "GroupieApp";
            this.BtnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSelfieApp.Location = new System.Drawing.Point(829, 120);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(192, 32);
            this.BtnSelfieApp.TabIndex = 14;
            this.BtnSelfieApp.Text = "SelfieApp";
            this.BtnSelfieApp.UseVisualStyleBackColor = true;
            this.BtnSelfieApp.Click += new System.EventHandler(this.BtnSelfieApp_Click);
            // 
            // BtnPicturebox
            // 
            this.BtnPicturebox.Location = new System.Drawing.Point(488, 86);
            this.BtnPicturebox.Name = "BtnPicturebox";
            this.BtnPicturebox.Size = new System.Drawing.Size(173, 29);
            this.BtnPicturebox.TabIndex = 15;
            this.BtnPicturebox.Text = "Picturebox";
            this.BtnPicturebox.UseVisualStyleBackColor = true;
            this.BtnPicturebox.Click += new System.EventHandler(this.BtnPicturebox_Click);
            // 
            // BtnPicturebox2
            // 
            this.BtnPicturebox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnPicturebox2.Location = new System.Drawing.Point(829, 157);
            this.BtnPicturebox2.Name = "BtnPicturebox2";
            this.BtnPicturebox2.Size = new System.Drawing.Size(192, 31);
            this.BtnPicturebox2.TabIndex = 16;
            this.BtnPicturebox2.Text = "Picturebox2";
            this.BtnPicturebox2.UseVisualStyleBackColor = true;
            this.BtnPicturebox2.Click += new System.EventHandler(this.button16_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.Location = new System.Drawing.Point(488, 50);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(173, 28);
            this.BtnCombo.TabIndex = 17;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.button17_Click);
            // 
            // BtnCheckbox
            // 
            this.BtnCheckbox.Location = new System.Drawing.Point(309, 83);
            this.BtnCheckbox.Name = "BtnCheckbox";
            this.BtnCheckbox.Size = new System.Drawing.Size(173, 31);
            this.BtnCheckbox.TabIndex = 18;
            this.BtnCheckbox.Text = "Checkbox";
            this.BtnCheckbox.UseVisualStyleBackColor = true;
            this.BtnCheckbox.Click += new System.EventHandler(this.BtnCheckbox_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Info;
            this.BtnLogin.Location = new System.Drawing.Point(132, 121);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(89, 28);
            this.BtnLogin.TabIndex = 19;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.button19_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExit.Location = new System.Drawing.Point(21, 121);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(83, 28);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnCheckbox);
            this.Controls.Add(this.BtnCombo);
            this.Controls.Add(this.BtnPicturebox2);
            this.Controls.Add(this.BtnPicturebox);
            this.Controls.Add(this.BtnSelfieApp);
            this.Controls.Add(this.BtnGroupieApp);
            this.Controls.Add(this.BtnProgress);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnTalk);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnRandomCombo);
            this.Controls.Add(this.BtnRoboticCell);
            this.Controls.Add(this.Arduino);
            this.Controls.Add(this.BtnManufacturingCell);
            this.Controls.Add(this.BtnJohari);
            this.Controls.Add(this.BtnABCAnalysis);
            this.Controls.Add(this.BtnRadio);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.Button Arduino;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnPicturebox;
        private System.Windows.Forms.Button BtnPicturebox2;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheckbox;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button1;
    }
}

