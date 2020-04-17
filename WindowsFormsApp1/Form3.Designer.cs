namespace WindowsFormsApp1
{
    partial class frmCombo
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
            this.BtnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.BtnRemovelastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndLastItem = new System.Windows.Forms.Button();
            this.BtnRemovebyIndex = new System.Windows.Forms.Button();
            this.BtnRemovebyName = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelectedMethod1
            // 
            this.BtnShowSelectedMethod1.Location = new System.Drawing.Point(12, 0);
            this.BtnShowSelectedMethod1.Name = "BtnShowSelectedMethod1";
            this.BtnShowSelectedMethod1.Size = new System.Drawing.Size(114, 51);
            this.BtnShowSelectedMethod1.TabIndex = 0;
            this.BtnShowSelectedMethod1.Text = "Show selected method 1";
            this.BtnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod1.Click += new System.EventHandler(this.BtnShowSelected1);
            // 
            // BtnShowSelectedMethod2
            // 
            this.BtnShowSelectedMethod2.Location = new System.Drawing.Point(146, 0);
            this.BtnShowSelectedMethod2.Name = "BtnShowSelectedMethod2";
            this.BtnShowSelectedMethod2.Size = new System.Drawing.Size(112, 51);
            this.BtnShowSelectedMethod2.TabIndex = 1;
            this.BtnShowSelectedMethod2.Text = "Show selected method 2";
            this.BtnShowSelectedMethod2.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod2.Click += new System.EventHandler(this.BtnShowSelected2);
            // 
            // BtnRemovelastitem
            // 
            this.BtnRemovelastitem.Location = new System.Drawing.Point(296, 86);
            this.BtnRemovelastitem.Name = "BtnRemovelastitem";
            this.BtnRemovelastitem.Size = new System.Drawing.Size(108, 50);
            this.BtnRemovelastitem.TabIndex = 2;
            this.BtnRemovelastitem.Text = "Remove last item";
            this.BtnRemovelastitem.UseVisualStyleBackColor = true;
            this.BtnRemovelastitem.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnRemove2ndLastItem
            // 
            this.BtnRemove2ndLastItem.Location = new System.Drawing.Point(296, 171);
            this.BtnRemove2ndLastItem.Name = "BtnRemove2ndLastItem";
            this.BtnRemove2ndLastItem.Size = new System.Drawing.Size(108, 54);
            this.BtnRemove2ndLastItem.TabIndex = 3;
            this.BtnRemove2ndLastItem.Text = "Remove 2nd last item";
            this.BtnRemove2ndLastItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLastItem.Click += new System.EventHandler(this.BtnRemove2ndLastItem_Click);
            // 
            // BtnRemovebyIndex
            // 
            this.BtnRemovebyIndex.Location = new System.Drawing.Point(12, 340);
            this.BtnRemovebyIndex.Name = "BtnRemovebyIndex";
            this.BtnRemovebyIndex.Size = new System.Drawing.Size(121, 52);
            this.BtnRemovebyIndex.TabIndex = 4;
            this.BtnRemovebyIndex.Text = "remove by index";
            this.BtnRemovebyIndex.UseVisualStyleBackColor = true;
            this.BtnRemovebyIndex.Click += new System.EventHandler(this.BtnRemovebyIndex_Click);
            // 
            // BtnRemovebyName
            // 
            this.BtnRemovebyName.Location = new System.Drawing.Point(146, 340);
            this.BtnRemovebyName.Name = "BtnRemovebyName";
            this.BtnRemovebyName.Size = new System.Drawing.Size(132, 52);
            this.BtnRemovebyName.TabIndex = 5;
            this.BtnRemovebyName.Text = "Remove by name";
            this.BtnRemovebyName.UseVisualStyleBackColor = true;
            this.BtnRemovebyName.Click += new System.EventHandler(this.BtnRemovebyName_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(23, 86);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 6;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(329, 355);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show selected method 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemovebyName);
            this.Controls.Add(this.BtnRemovebyIndex);
            this.Controls.Add(this.BtnRemove2ndLastItem);
            this.Controls.Add(this.BtnRemovelastitem);
            this.Controls.Add(this.BtnShowSelectedMethod2);
            this.Controls.Add(this.BtnShowSelectedMethod1);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelectedMethod1;
        private System.Windows.Forms.Button BtnShowSelectedMethod2;
        private System.Windows.Forms.Button BtnRemovelastitem;
        private System.Windows.Forms.Button BtnRemove2ndLastItem;
        private System.Windows.Forms.Button BtnRemovebyIndex;
        private System.Windows.Forms.Button BtnRemovebyName;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button button1;
    }
}