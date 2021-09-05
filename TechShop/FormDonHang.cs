using AppTier;
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

namespace TechShop
{
    public partial class FormDonHang : Form
    {
        DbOrder dbOrder;
        DataTable dtOrder = null;
        public FormDonHang()
        {
            InitializeComponent();
            dbOrder = new DbOrder();
            LoadData();
        }

        public void ReLoad()
        {
            this.Controls.Clear();
            InitializeComponent();
            dbOrder = new DbOrder();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtOrder = new DataTable();
                dtOrder.Clear();
                dtOrder = dbOrder.getAllOrder().Tables[0];


                List<Order> productDetails = new List<Order>();
                productDetails = Model.ConvertDataTable<Order>(dtOrder);
                List<OrderItem> productIem = new List<OrderItem>();
                int x = 0;
                foreach (Order i in productDetails)
                {
                    OrderItem item = new OrderItem();
                    item.lbName.Text = i.customer_id.ToString();
                    item.lbID.Text = i.order_id.ToString();
                    item.lbSale.Text = i.seller_id.ToString();
                    item.lbSoldDate.Text = i.sold_date.ToString();
                    item.lbTotalMoney.Text = i.total_money.ToString();

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsOrder.Controls.Add(item);
                    productIem.Add(item);
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
            dbOrder = new DbOrder();
            LoadData();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormThemSP formThemSP = new FormThemSP()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formThemSP.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formThemSP);
            formThemSP.Show();

            formThemSP.btnReturn.Click += btnReturn_Click;
            formThemSP.btnExit.Click += btnReturn_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
