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
        DbCustomer dbCustomer = new DbCustomer();
        DataTable dtCustomer = new DataTable();
        DbOrder dbOrder = new DbOrder();
        DataTable dtOrder = new DataTable();
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
                dtCustomer.Clear();
                dtCustomer = dbCustomer.getAllCustomer().Tables[0]; 
                dtOrder.Clear();
                dtOrder = dbOrder.getAllOrderWithInfo().Tables[0];

                cbCustomer.DisplayMember = "name";
                cbCustomer.ValueMember = "customer_id";
                cbCustomer.DataSource = dtCustomer;
                cbCustomer.SelectedItem = null;
                cbCustomer.Text = "Khách hàng";

                List<Order> orderDetails = new List<Order>();
                orderDetails = Model.ConvertDataTable<Order>(dtOrder);
                List<OrderItem> orderItem = new List<OrderItem>();
                int x = 0;
                foreach (DataRow dr in dtOrder.Rows)
                {
                    OrderItem item = new OrderItem();

                    item.lbName.Text = dr["Ten"].ToString();
                    item.lbID.Text = dr["ID"].ToString();
                    item.lbSale.Text = dr["TenNV"].ToString();
                    item.lbSoldDate.Text = dr["date"].ToString();
                    item.lbTotalMoney.Text = dr["money"].ToString();
                    item.btnView.Text = dr["ID"].ToString();
                    item.btnView.Click += btnView_Click;

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsOrder.Controls.Add(item);
                    orderItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }


                //dtOrder.Clear();
                //dtOrder = dbOrder.Income("20210905").Tables[0];
                //dgv.DataSource = dtOrder;
            }
            catch (SqlException eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(((Button)sender).Text);
            this.Controls.Clear();
            FormDonHang_ChiTiet form= new FormDonHang_ChiTiet(id)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Show();

            form.btnReturn.Click += btnReturn_Click;
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

        private void lbName_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (OrderItem i in pnDsOrder.Controls)
            {
                i.ck.Checked = ckAll.Checked;
            }
        }
    }
}
