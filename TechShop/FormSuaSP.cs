using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTier;

namespace TechShop
{
    public partial class FormSuaSP : Form
    {
        DbCategory dbCategory = new DbCategory();
        DataTable dtCategory = new DataTable();
        DbBrand dbBrand = new DbBrand();
        DataTable dtBrand = new DataTable();
        DbInsurance dbInsurance = new DbInsurance();
        DataTable dtInsurance = new DataTable();
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
                dtProduct = dbProduct.getProductById(oddID.ToString()).Tables[0];

                productList = Model.ConvertDataTable<Product>(dtProduct);

                txtName.Text = productList[0].name;
                txtPrice.Text = productList[0].price.ToString();
                txtImgName.Text = productList[0].image;

                dtBrand.Clear();
                dtBrand = dbBrand.getAllBrand().Tables[0];
                dtCategory.Clear();
                dtCategory = dbCategory.getAllCategory().Tables[0];
                dtInsurance.Clear();
                dtInsurance = dbInsurance.getAllInsurance().Tables[0];

                cbBrand.DisplayMember = "name";
                cbBrand.ValueMember = "brand_id";
                cbBrand.DataSource = dtBrand;
                cbBrand.SelectedValue = productList[0].brand_id;

                cbCategory.DisplayMember = "name";
                cbCategory.ValueMember = "category_id";
                cbCategory.DataSource = dtCategory;
                cbCategory.SelectedValue = productList[0].category_id;

                cbIsurance.DisplayMember = "time";
                cbIsurance.ValueMember = "insurance_id";
                cbIsurance.DataSource = dtInsurance;
                cbIsurance.SelectedValue = productList[0].insuarence_id;

                //pbImage.Image = Image.FromFile(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\TechShop\\ImageStorage\\" + txtImgName.Text);

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                pbImage.Image = null;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbProduct = new DbProduct();
            LoadData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbImage.Image = new Bitmap(open.FileName);
                // image file path  
                txtImgPath.Text = open.FileName;
                txtImgName.Text = Path.GetFileName(open.FileName);
                
            }
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            try
            {
                string p1 = txtImgPath.Text;
                string p2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\TechShop\\ImageStorage\\" + txtImgName.Text;
                File.Copy(p1, p2, true);
                DialogResult result = MessageBox.Show("Save image successfully", "", MessageBoxButtons.OK);
            }
            catch (Exception ee)
            {
                //DialogResult result = MessageBox.Show(ee.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbProduct.updateProduct(ref err, Int32.Parse(oddID), txtName.Text, Int32.Parse(txtPrice.Text),
                    txtImgName.Text, Int32.Parse(cbBrand.SelectedValue.ToString()),
                    Int32.Parse(cbCategory.SelectedValue.ToString()),
                    Int32.Parse(cbIsurance.SelectedValue.ToString()));

                btnSaveImg.PerformClick();

                if (status)
                {
                    MessageBox.Show("Sua san pham thanh cong");
                    btnReturn.PerformClick();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbProduct.deleteProduct(ref err, Int32.Parse(oddID));
                btnSaveImg.PerformClick();
                if (status)
                {
                    MessageBox.Show("Xoa san pham thanh cong");
                    btnReturn.PerformClick();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
