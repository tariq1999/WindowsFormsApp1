using System;
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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        this.DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true )
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName ("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed2.Checked == true)
                rdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else
                rdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen2.Checked == true)
                rdoGreen2.ForeColor = Color.FromName("green");
            else
                rdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue2.Checked == true)
                rdoBlue2.ForeColor = Color.FromName("blue");
            else
                rdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow2.Checked == true)
                rdoYellow2.ForeColor = Color.FromName("yellow");
            else
                rdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");

            rdoRed2.Checked = false;
            rdoGreen2.Checked = false;
            rdoBlue2.Checked = false;
            rdoYellow2.Checked = false;

            rdoRed2.ForeColor = Color.FromName("black");
            rdoGreen2.ForeColor = Color.FromName("black");
            rdoBlue2.ForeColor = Color.FromName("black");
            rdoYellow2.ForeColor = Color.FromName("black");
        }
    }
}
