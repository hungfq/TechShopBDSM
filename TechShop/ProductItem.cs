using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }


        private void lbImage_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\ImageStorage\\" + lbImage.Text;
                System.Diagnostics.Process.Start(name);
            }
            catch (Exception ee)
            {
                DialogResult result = MessageBox.Show(ee.ToString(), "", MessageBoxButtons.OK);
            }
        }
    }
}
