using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tesseract;

namespace 고시프_프로젝트
{
    public partial class user : Form
    {
     
        public user()
        {
            InitializeComponent();
        }
        private void FileOpen(object sender, EventArgs e)
        {
            ImageFile.FileOpen.Open(pictureBox1);
        }

        private void InterimVerificationButton(object sender, EventArgs e)
        {
            try
            {
                ImageFile.FileBinary.Binary(pictureBox1);
                ImageFile.FileAnalysis.Analysis();
            }
            catch
            {
               
            }
        }
    }
}