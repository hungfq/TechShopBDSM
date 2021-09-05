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

namespace TechShop
{
    public partial class FormThemSP : Form
    {
        public FormThemSP()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbImage.Image = new Bitmap(open.FileName);
                // image file path  
                txtImgPath.Text = open.FileName;

                File.Copy(txtImgPath.Text, 
                    Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
                    Path.GetFileName(txtImgPath.Text)),true);
            }
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(txtImgPath.Text,
                        Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
                        Path.GetFileName(txtImgPath.Text)), true);
                DialogResult result = MessageBox.Show("Save image successfully", "", MessageBoxButtons.OK);
            }
            catch (Exception)
            { }
        }
    }
}
