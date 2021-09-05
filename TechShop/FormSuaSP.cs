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
    public partial class FormSuaSP : Form
    {
        DbProduct dbProduct;
        DataTable dtProduct;
        List<Product> productList = new List<Product>();
        string oddID;
        public FormSuaSP(string id)
        {
            InitializeComponent();
            dbProduct = new DbProduct();
            oddID = id;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtProduct = new DataTable();
                dtProduct.Clear();
                dtProduct = dbProduct.getProduct(oddID.ToString()).Tables[0];

                productList = Model.ConvertDataTable<Product>(dtProduct);

                txtName.Text = productList[0].name;
                txtPrice.Text = productList[0].price.ToString();
                txtImgPath.Text = productList[0].image;

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

    }
}
