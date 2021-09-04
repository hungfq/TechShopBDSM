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
    public partial class FormBanHang : Form
    {
        DbProduct dbProduct;
        DataTable dtProduct = null;
        List<Product> cartList = new List<Product>();
        List<CartItem> cartListItem = new List<CartItem>();
        int cart_y = 0;
        public FormBanHang()
        {
            InitializeComponent();
            dbProduct = new DbProduct();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtProduct = new DataTable();
                dtProduct.Clear();
                dtProduct = dbProduct.getProduct().Tables[0];


                List<Product> productDetails = new List<Product>();
                productDetails = Model.ConvertDataTable<Product>(dtProduct);
                List<BanHang_ListItem> productIem = new List<BanHang_ListItem>();
                int x = 0;
                foreach (Product i in productDetails)
                {
                    BanHang_ListItem item = new BanHang_ListItem();
                    item.lbName.Text = i.name;
                    item.lbPrice.Text = i.price.ToString();
                    item.lbID.Text = i.product_id.ToString();
                    item.btnAdd.Text = i.product_id.ToString();
                    item.btnAdd.Click += btnAdd_Click;

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnListItem.Controls.Add(item);

                    item.Dock = DockStyle.Top;
                    item.BringToFront();

                    productIem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            obj.Parent.Parent.Controls.Remove(obj.Parent);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            CartItem item = new CartItem();
            item.lbID.Text = obj.Text;

            item.btnRemove.Click += btnRemove_Click;
            item.Location = new System.Drawing.Point(0, cart_y);
            item.Dock = DockStyle.Top;
            item.BringToFront();
            item.Visible = true;
            pnCart.Controls.Add(item);
            cartListItem.Add(item);
            cart_y += Int32.Parse(item.Height.ToString());
            obj.Parent.Parent.Controls.Remove(obj.Parent);
        }
        //public void AddItemToCard(Product product)
        //{
        //    CartItem item = new CartItem();
        //    item.lbID.Text = product.product_id.ToString();
        //    item.lbName.Text = product.name;
        //    item.lbPrice.Text = product.price.ToString();

        //    item.Visible = true;
        //    item.Location = new System.Drawing.Point(0, cart_y);
        //    pnCart.Controls.Add(item);
        //    cartListItem.Add(item);
        //    cart_y += Int32.Parse(item.Height.ToString());
        //}

    }
}
