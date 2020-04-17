namespace WindowsFormsApp1
{
    partial class frmPicturebox
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
            this.btnBack = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.pictry2 = new System.Windows.Forms.PictureBox();
            this.btnImageFromSource = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(687, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(165, 76);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(295, 301);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.pictTry_Click);
            // 
            // pictry2
            // 
            this.pictry2.Location = new System.Drawing.Point(480, 76);
            this.pictry2.Name = "pictry2";
            this.pictry2.Size = new System.Drawing.Size(289, 301);
            this.pictry2.TabIndex = 2;
            this.pictry2.TabStop = false;
            this.pictry2.Click += new System.EventHandler(this.pictry2_Click);
            // 
            // btnImageFromSource
            // 
            this.btnImageFromSource.Location = new System.Drawing.Point(31, 109);
            this.btnImageFromSource.Name = "btnImageFromSource";
            this.btnImageFromSource.Size = new System.Drawing.Size(91, 73);
            this.btnImageFromSource.TabIndex = 3;
            this.btnImageFromSource.Text = "Image From Source";
            this.btnImageFromSource.UseVisualStyleBackColor = true;
            this.btnImageFromSource.Click += new System.EventHandler(this.btnImageFromSource_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(31, 27);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(91, 63);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click_1);
            // 
            // frmPicturebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnImageFromSource);
            this.Controls.Add(this.pictry2);
            this.Controls.Add(this.picTry);
            this.Controls.Add(this.btnBack);
            this.Name = "frmPicturebox";
            this.Text = "Picturebox";
            this.Load += new System.EventHandler(this.frmPicturebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.PictureBox pictry2;
        private System.Windows.Forms.Button btnImageFromSource;
        private System.Windows.Forms.Button btnLoadImage;
    }
}