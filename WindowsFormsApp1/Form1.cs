
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        { 

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Tariq" )
            {
                MessageBox.Show("correct username");
            }
            else
            {
                MessageBox.Show("Incorrect username");
            }
            if (TxtPassword.Text == "1234")
            {
                MessageBox.Show("correct Password");
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
            if (TxtUsername.Text == "Tariq" && TxtPassword.Text == "1234")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login unsuccessful");
            }
        }

        private void BtnSelfieApp_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnPicturebox_Click(object sender, EventArgs e)
        {
            frmPicturebox frm = new frmPicturebox();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmrandom frm = new frmrandom();
            frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
