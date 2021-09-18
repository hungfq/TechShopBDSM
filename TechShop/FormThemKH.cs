using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTier;

namespace TechShop
{
    public partial class FormThemKH : Form
    {
        DbCustomer dbCustomer = new DbCustomer();
        public FormThemKH()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbCustomer.insertCustomer(ref err,txtName.Text,Int32.Parse(txtAge.Text),
                    txtSDT.Text);
                if (status)
                {
                    MessageBox.Show("Them khach hang thanh cong");
                    btnExit.PerformClick();
                }
                else
                    MessageBox.Show(err);
            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
