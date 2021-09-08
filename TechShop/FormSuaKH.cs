using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTier;

namespace TechShop
{
    public partial class FormSuaKH : Form
    {
        DbCustomer dbCustomer;
        DataTable dtCustomer;
        List<Customer> customerList = new List<Customer>();
        string oddID;
        public FormSuaKH(String id)
        {
            InitializeComponent();
            dbCustomer = new DbCustomer();
            oddID = id;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                dtCustomer = dbCustomer.getCustomerById(oddID.ToString()).Tables[0];

                customerList = Model.ConvertDataTable<Customer>(dtCustomer);

                txtName.Text = customerList[0].name;
                txtAge.Text = customerList[0].age.ToString();
                txtSDT.Text = customerList[0].phone_number;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbCustomer = new DbCustomer();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbCustomer.updateCustomer(ref err, Int32.Parse(oddID),
                    txtName.Text, Int32.Parse(txtAge.Text),txtSDT.Text);
                if (status)
                    MessageBox.Show("Sua khach hang thanh cong");
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
