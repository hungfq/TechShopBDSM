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
        DbCustomer dbCustomer = new DbCustomer();
        DataTable dtCustomer = new DataTable();
        DbCategory dbCategory = new DbCategory();
        DataTable dtCategory = new DataTable();
        DbBrand dbBrand = new DbBrand();
        DataTable dtBrand = new DataTable();
        DbProduct dbProduct;
        DataTable dtProduct = new DataTable();
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
                dtCustomer.Clear();
                dtCustomer = dbCustomer.getAllCustomer().Tables[0];
                dtBrand.Clear();
                dtBrand = dbBrand.getAllBrand().Tables[0];
                dtCategory.Clear();
                dtCategory = dbCategory.getAllCategory().Tables[0];
                dtProduct.Clear();
                dtProduct = dbProduct.getAllProduct().Tables[0];

                cbBrand.DisplayMember = "name";
                cbBrand.ValueMember = "brand_id";
                cbBrand.DataSource = dtBrand;
                cbBrand.SelectedItem = null;
                cbBrand.Text = "Chọn nhãn hiệu";

                cbCategory.DisplayMember = "name";
                cbCategory.ValueMember = "category_id";
                cbCategory.DataSource = dtCategory;
                cbCategory.SelectedItem = null;
                cbCategory.Text = "Chọn loại sản phẩm";

                cbCustomer.DisplayMember = "name";
                cbCustomer.ValueMember = "customer_id";
                cbCustomer.DataSource = dtCustomer;
                cbCustomer.SelectedItem = null;
                cbCustomer.Text = "Khách hàng";

                List<Product> productDetails = new List<Product>();
                productDetails = Model.ConvertDataTable<Product>(dtProduct);
                List<BanHang_ListItem> productIem = new List<BanHang_ListItem>();
                int x = 0;
                foreach (Product i in productDetails)
                {
                    // add item to list item
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
        private void quantity_valueChange(object sender, EventArgs e)
        {
            UpdateTxtTotalMoney();
        }
        private void UpdateTxtTotalMoney()
        {
            int sum = 0;
            foreach(CartItem i in cartListItem)
            {
                sum += Int32.Parse(i.lbPrice.Text)* Int32.Parse(i.quantity.Value.ToString());
            }
            lbTotalMoney.Text = sum.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            cartListItem.Remove((CartItem)obj.Parent);
            obj.Parent.Parent.Controls.Remove(obj.Parent);
            UpdateTxtTotalMoney();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            CartItem item = new CartItem();
            int id = Int32.Parse(obj.Text);

            DataTable dt = new DataTable();
            dt = dbProduct.getProductById(id.ToString()).Tables[0];
            List<Product> pdDetails = new List<Product>();
            pdDetails = Model.ConvertDataTable<Product>(dt);
            // add item to cart
            
            item.lbID.Text = obj.Text;
            item.lbName.Text = pdDetails[0].name;
            item.lbPrice.Text = pdDetails[0].price.ToString();

            item.btnRemove.Click += btnRemove_Click;
            item.quantity.ValueChanged += quantity_valueChange;
            item.Location = new System.Drawing.Point(0, cart_y);
            item.Dock = DockStyle.Top;
            item.BringToFront();
            item.Visible = true;
            pnCart.Controls.Add(item);
            cartListItem.Add(item);
            cart_y += Int32.Parse(item.Height.ToString());
            obj.Parent.Parent.Controls.Remove(obj.Parent);

            UpdateTxtTotalMoney();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbProduct = new DbProduct();
            LoadData();
        }

    }
}
