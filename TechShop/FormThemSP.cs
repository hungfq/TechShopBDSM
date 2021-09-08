using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppTier;
using System.Data.SqlClient;

namespace TechShop
{
    public partial class FormThemSP : Form
    {
        DbCategory dbCategory = new DbCategory();
        DataTable dtCategory = new DataTable();
        DbBrand dbBrand = new DbBrand();
        DataTable dtBrand = new DataTable();
        DbInsurance dbInsurance = new DbInsurance();
        DataTable dtInsurance = new DataTable();

        public FormThemSP()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtBrand.Clear();
                dtBrand = dbBrand.getAllBrand().Tables[0];
                dtCategory.Clear();
                dtCategory = dbCategory.getAllCategory().Tables[0];
                dtInsurance.Clear();
                dtInsurance = dbInsurance.getAllInsurance().Tables[0];

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

                cbIsurance.DisplayMember = "time";
                cbIsurance.ValueMember = "insurance_id";
                cbIsurance.DataSource = dtInsurance;
                cbIsurance.SelectedItem = null;
                cbIsurance.Text = "Chọn thời gian bảo hành";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
                this.Close();
            }
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
                File.Copy(p1,p2, true);
                DialogResult result = MessageBox.Show("Save image successfully", "", MessageBoxButtons.OK);
            }
            catch (Exception ee)
            {
                DialogResult result = MessageBox.Show(ee.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
