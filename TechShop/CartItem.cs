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
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }
        private void Ctl_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in Controls)
            {
                if (ctl.GetType() == typeof(NumericUpDown))
                    ctl.MouseWheel += Ctl_MouseWheel;
            }
        }
    }
}
