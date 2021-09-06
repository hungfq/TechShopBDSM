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
        DbCategory dbCategory = new DbCategory();
        DataTable dtCategory = new DataTable();
        DbBrand dbBrand = new DbBrand();
        DataTable dtBrand = new DataTable();
        DbProduct dbProduct;
        DataTable dtProduct = new DataTable();
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
                cbBrand.Text = "Nhãn hiệu";

                cbCategory.DisplayMember = "name";
                cbCategory.ValueMember = "category_id";
                cbCategory.DataSource = dtCategory;
                cbCategory.SelectedItem = null;
                cbCategory.Text = "Loại sản phẩm";

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
                    item.btnModify.Text = i.product_id.ToString();
                    item.btnModify.Click += btnModify_Click;

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
                this.Close();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbProduct = new DbProduct();
            LoadData();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            // dựng form
            this.Controls.Clear();
            FormSuaSP formSuaSP = new FormSuaSP(((Button)sender).Text)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formSuaSP.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formSuaSP);
            formSuaSP.Show();
            //nav
            formSuaSP.btnReturn.Click += btnReturn_Click;
            formSuaSP.btnCancel.Click += btnReturn_Click;
            

        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            // dựng form
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
            // nav
            formThemSP.btnReturn.Click += btnReturn_Click;
            formThemSP.btnExit.Click += btnReturn_Click;
            
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ProductItem i in pnDsSp.Controls)
            {
                i.ck.Checked = ckAll.Checked;
            }
        }
    }
}
