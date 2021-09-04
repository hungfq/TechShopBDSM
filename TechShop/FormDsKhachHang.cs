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
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                dtCustomer = dbCustomer.getAllCustomer().Tables[0];


                List<Customer> customerDetails = new List<Customer>();
                customerDetails = Model.ConvertDataTable<Customer>(dtCustomer);
                List<CustomerItem> cusItem = new List<CustomerItem>();
                int x = 0;
                foreach (Customer i in customerDetails)
                {
                    CustomerItem item = new CustomerItem();
                    item.lbName.Text = i.name;
                    item.lbAge.Text = i.age.ToString();
                    item.lbID.Text = i.customer_id.ToString();
                    item.lbPhoneNum.Text = i.phone_number.ToString();

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
    }
}
