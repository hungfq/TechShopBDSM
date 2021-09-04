using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop
{
    public partial class FormParent : Form
    {
        FormMain main;
        public FormParent()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            main = new FormMain();
            main.MdiParent = this;
            main.Dock = DockStyle.Left;
            main.Show();
            pnMain.Dock = DockStyle.Right;
        }
    }
}
