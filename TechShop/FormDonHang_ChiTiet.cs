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
    public partial class FormDonHang_ChiTiet : Form
    {
        DbOrderDetail dbOrderDetail;
        DataTable dtOrderDetail = null;
        DbProduct dbProduct = new DbProduct();
        DataTable dt1 = new DataTable();
        List<Product> pdDetails = new List<Product>();
        int oddID;
        public FormDonHang_ChiTiet(int id)
        {
            InitializeComponent();
            dbOrderDetail = new DbOrderDetail();
            oddID = id;
            LoadData();
        }


        public void ReLoad()
        {
            this.Controls.Clear();
            InitializeComponent();
            dbOrderDetail = new DbOrderDetail();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtOrderDetail = new DataTable();
                dtOrderDetail.Clear();
                dtOrderDetail = dbOrderDetail.getOrderDetail(oddID.ToString()).Tables[0];

                List<OrderDetail> orderDetails = new List<OrderDetail>();
                orderDetails = Model.ConvertDataTable<OrderDetail>(dtOrderDetail);
                List<OrderDetailItem> orderIDetailtem = new List<OrderDetailItem>();
                int x = 0;
                foreach (OrderDetail i in orderDetails)
                {
                    OrderDetailItem item = new OrderDetailItem();
                    item.lbID.Text = i.orderdetail_id.ToString();
                    item.lbOrderID.Text = i.order_id.ToString();
                    //DataSet
                    
                    dt1 = dbProduct.getProductById(i.product_id.ToString()).Tables[0];
                    pdDetails = Model.ConvertDataTable<Product>(dt1);
                    // add item to cart
                    item.lbProductName.Text = pdDetails[0].name;
                    item.lbQuantity.Text = i.quantity.ToString();

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnHome.Controls.Add(item);
                    orderIDetailtem.Add(item);
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
            dbOrderDetail = new DbOrderDetail();
            LoadData();
        }
    }
}
