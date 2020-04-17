﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDonut.Checked == true)
            {
                msg = msg + ChkDonut.Text;
            }
            if (ChkBrownie.Checked == true)
            {
                msg = msg + ChkBrownie.Text;
            }
            if (msg.Length>0)
            {
                MessageBox.Show(msg + "selected");
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
