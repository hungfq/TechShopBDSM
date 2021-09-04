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
using AppTier;

namespace TechShop
{
    public partial class FormDsSanPham : Form
    {
        DbProduct dbProduct;
        DataTable dtProduct = null;
        public FormDsSanPham()
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
                List<ProductItem> productIem = new List<ProductItem>();
                int x = 0;
                foreach (Product i in productDetails)
                {
                    ProductItem item = new ProductItem();
                    item.lbName.Text = i.name;
                    item.lbBrand.Text = i.brand_id.ToString();
                    item.lbCategory.Text = i.category_id.ToString();
                    item.lbID.Text = i.product_id.ToString();
                    item.lbImage.Text = i.image;
                    item.lbPrice.Text = i.price.ToString();
                    item.lbInsuarence.Text = i.insuarence_id.ToString();

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsSp.Controls.Add(item);
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
            dbProduct = new DbProduct();
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
    }
}
