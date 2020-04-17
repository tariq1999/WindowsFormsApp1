using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class frmPicturebox : Form
    {
        Assembly _assembly; 
        Stream _imageStream;
        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
        public frmPicturebox()
        {
            InitializeComponent();
          
            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

        }
private void btnLoadImage_Click_1(object sender, EventArgs e)
    {
            try
            {
                picTry.Image = Image.FromFile("C:\\Users\\HP\\Desktop\\Engineering\\Sem 3\\IE 331\\trial.jpeg");
            }
            catch
            {
                MessageBox.Show("Image File Not Found");
            }
    }
    
           


    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnImageFromSource_Click(object sender, EventArgs e)
        {
           
            try
            {
                pictry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
               MessageBox.Show("Error creating image");
            }
        }

        private void frmPicturebox_Load(object sender, EventArgs e)
        {
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("WindowsFormsApp1.Resource.classic.jpg");
                
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictry2_Click(object sender, EventArgs e)
        {

        }

        private void pictTry_Click(object sender, EventArgs e)
        {
            
        }
    }
}
