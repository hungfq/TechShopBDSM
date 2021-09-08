using AppTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop
{
    public partial class FormDsKhachHang : Form
    {
        List<CustomerItem> cusItem;
        List<Customer> customer;
        DbCustomer dbCustomer;
        DataTable dtCustomer = null;
        public FormDsKhachHang()
        {
            InitializeComponent();
            dbCustomer = new DbCustomer();
            LoadData();
        }
        
        public void LoadData()
        {
            cusItem = new List<CustomerItem>();
            customer = new List<Customer>();
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                dtCustomer = dbCustomer.getAllCustomer().Tables[0];


                
                customer = Model.ConvertDataTable<Customer>(dtCustomer);
                
                int x = 0;
                foreach (Customer i in customer)
                {
                    CustomerItem item = new CustomerItem();
                    item.lbName.Text = i.name;
                    item.lbAge.Text = i.age.ToString();
                    item.lbID.Text = i.customer_id.ToString();
                    item.lbPhoneNum.Text = i.phone_number.ToString();
                    item.btnModify.Text = i.customer_id.ToString();
                    item.btnModify.Click += btnModify_Click;

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsSp.Controls.Add(item);
                    cusItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormSuaKH form = new FormSuaKH(((Button)sender).Text)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Show();

            form.btnReturn.Click += btnReturn_Click;
            form.btnHuy.Click += btnReturn_Click;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbCustomer = new DbCustomer();
            LoadData();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormThemKH formThemKH = new FormThemKH()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formThemKH.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formThemKH);
            formThemKH.Show();

            formThemKH.btnReturn.Click += btnReturn_Click;
            formThemKH.btnExit.Click += btnReturn_Click;
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CustomerItem i in pnDsSp.Controls)
            {
                i.ck.Checked = ckAll.Checked;
            }
        }
    }
}
