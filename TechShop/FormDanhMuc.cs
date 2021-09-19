using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTier;

namespace TechShop
{
    public partial class FormDanhMuc : Form
    {
        DbBrand dbBrand = new DbBrand();
        DataTable dtBrand = new DataTable();
        List<Brand> brandDetails = new List<Brand>();
        List<ContentIdItem> brandItem = new List<ContentIdItem>();
        bool brandFlag = false;
        DbCategory dbCategory = new DbCategory();
        DataTable dtCategory = new DataTable();
        List<Category> categoryDetails = new List<Category>();
        List<ContentIdItem> categoryItem = new List<ContentIdItem>();
        bool categoryFlag = false;
        DbInsurance dbInsurance = new DbInsurance();
        DataTable dtInsurance = new DataTable();
        List<Insurance> insuranceDetails = new List<Insurance>();
        List<ContentIdItem> insuranceItem = new List<ContentIdItem>();
        bool insuranceFlag = false;
        public FormDanhMuc()
        {
            InitializeComponent();
            BrandLoadData();
            CategoryLoadData();
            InsuranceLoadData();
            pnBrand.VerticalScroll.Visible = false;
        }
        public void BrandLoadData()
        {
            try
            {
                dtBrand.Clear();
                dtBrand = dbBrand.getAllBrand().Tables[0];
                brandDetails = Model.ConvertDataTable<Brand>(dtBrand);
                brandDetails.Reverse();
                int x = 0;
                foreach (Brand i in brandDetails)
                {
                    ContentIdItem item = new ContentIdItem();
                    item.lbID.Text = i.brand_id.ToString();
                    item.txtContent.Text = i.name;
                    item.btnSave.Click += BrandUpdate_Click;
                    item.btnDelete.Click += BrandDelete_Click;
                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    item.Dock = DockStyle.Top;
                    pnBrand.Controls.Add(item);
                    brandItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        public void CategoryLoadData()
        {
            try
            {
                dtCategory.Clear();
                dtCategory = dbCategory.getAllCategory().Tables[0];
                categoryDetails = Model.ConvertDataTable<Category>(dtCategory);
                categoryDetails.Reverse();
                int x = 0;
                foreach (Category i in categoryDetails)
                {
                    ContentIdItem item = new ContentIdItem();
                    item.lbID.Text = i.category_id.ToString();
                    item.txtContent.Text = i.name;
                    item.btnSave.Click += CategoryUpdate_Click;
                    item.btnDelete.Click += CategoryDelete_Click;
                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    item.Dock = DockStyle.Top;
                    pnCategory.Controls.Add(item);
                    categoryItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        public void InsuranceLoadData()
        {
            try
            {
                dtInsurance.Clear();
                dtInsurance = dbInsurance.getAllInsurance().Tables[0];
                insuranceDetails = Model.ConvertDataTable<Insurance>(dtInsurance);
                insuranceDetails.Reverse();
                int x = 0;
                foreach (Insurance i in insuranceDetails)
                {
                    ContentIdItem item = new ContentIdItem();
                    item.lbID.Text = i.insurance_id.ToString();
                    item.txtContent.Text = i.time;
                    item.btnSave.Click += InsuranceUpdate_Click;
                    item.btnDelete.Click += InsuranceDelete_Click;
                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    item.Dock = DockStyle.Top;
                    pnInsurance.Controls.Add(item);
                    insuranceItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        private void BrandDelete_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbBrand.deleteBrand(ref err, father.lbID.Text);

                if (status)
                {
                    MessageBox.Show("Xoa thanh cong");
                    BrandReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void CategoryDelete_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbCategory.deleteCategory(ref err, father.lbID.Text);

                if (status)
                {
                    MessageBox.Show("Xoa thanh cong");
                    CategoryReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void InsuranceDelete_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbInsurance.deleteInsurance(ref err, father.lbID.Text);

                if (status)
                {
                    MessageBox.Show("Xoa thanh cong");
                    InsuranceReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void BrandUpdate_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbBrand.updateBrand(ref err, father.lbID.Text, father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Sua thanh cong");
                    BrandReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        
        private void CategoryUpdate_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbCategory.updateCategory(ref err, father.lbID.Text, father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Sua thanh cong");
                    CategoryReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void InsuranceUpdate_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbInsurance.updateInsurance(ref err, Int32.Parse(father.lbID.Text), father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Sua thanh cong");
                    InsuranceReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void BrandInsert_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbBrand.insertBrand(ref err, father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Them thanh cong");
                    BrandReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void CategoryInsert_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbCategory.insertCategory(ref err, father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Them thanh cong");
                    CategoryReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void InsuranceInsert_Click(object sender, EventArgs e)
        {
            ContentIdItem father = (ContentIdItem)((Button)sender).Parent;
            string err = "";
            try
            {
                bool status = dbInsurance.insertInsurance(ref err, father.txtContent.Text);

                if (status)
                {
                    MessageBox.Show("Them thanh cong");
                    InsuranceReload();
                }
                else
                    MessageBox.Show(err);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void btnBrandModify_Click(object sender, EventArgs e)
        {
            if (brandFlag)
            {
                btnBrandAdd.Enabled = true;
                brandFlag = false;
                foreach(ContentIdItem i in pnBrand.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.None;
                    i.txtContent.ReadOnly = true;
                    i.btnDelete.Visible = true;
                    i.btnSave.Visible = false;
                }
            }
            else
            {
                btnBrandAdd.Enabled = false;
                foreach (ContentIdItem i in pnBrand.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.FixedSingle;
                    i.txtContent.ReadOnly = false;
                    i.btnDelete.Visible = false;
                    i.btnSave.Visible = true;
                }
                brandFlag = true;
            }
        }
        private void btnCategoryModify_Click(object sender, EventArgs e)
        {
            if (categoryFlag)
            {
                btnCategoryAdd.Enabled = true;
                categoryFlag = false;
                foreach (ContentIdItem i in pnCategory.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.None;
                    i.txtContent.ReadOnly = true;
                    i.btnDelete.Visible = true;
                    i.btnSave.Visible = false;
                }
            }
            else
            {
                btnCategoryAdd.Enabled = false;
                foreach (ContentIdItem i in pnCategory.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.FixedSingle;
                    i.txtContent.ReadOnly = false;
                    i.btnDelete.Visible = false;
                    i.btnSave.Visible = true;
                }
                categoryFlag = true;
            }
        }
        private void btnInsuranceModify_Click(object sender, EventArgs e)
        {
            if (insuranceFlag)
            {
                btnInsuranceAdd.Enabled = true;
                insuranceFlag = false;
                foreach (ContentIdItem i in pnInsurance.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.None;
                    i.txtContent.ReadOnly = true;
                    i.btnDelete.Visible = true;
                    i.btnSave.Visible = false;
                }
            }
            else
            {
                btnInsuranceAdd.Enabled = false;
                foreach (ContentIdItem i in pnInsurance.Controls)
                {
                    i.txtContent.BorderStyle = BorderStyle.FixedSingle;
                    i.txtContent.ReadOnly = false;
                    i.btnDelete.Visible = false;
                    i.btnSave.Visible = true;
                }
                insuranceFlag = true;
            }
        }
        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            brandFlag = true;
            btnBrandModify.PerformClick();

            ContentIdItem item = new ContentIdItem();
            item.lbID.Text = "";
            item.txtContent.BorderStyle = BorderStyle.FixedSingle;
            item.txtContent.ReadOnly = false;
            item.btnSave.Visible = true;
            item.btnSave.Click += BrandInsert_Click;
            item.Visible = true;
            item.Location = new System.Drawing.Point(0, 0);
            item.Dock = DockStyle.Top;
            pnBrand.Controls.Add(item);
            btnBrandAdd.Enabled = false;
            btnBrandModify.Enabled = false;
        }
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            categoryFlag = true;
            btnCategoryModify.PerformClick();

            ContentIdItem item = new ContentIdItem();
            item.lbID.Text = "";
            item.txtContent.BorderStyle = BorderStyle.FixedSingle;
            item.txtContent.ReadOnly = false;
            item.btnSave.Visible = true;
            item.btnSave.Click += CategoryInsert_Click;
            item.Visible = true;
            item.Location = new System.Drawing.Point(0, 0);
            item.Dock = DockStyle.Top;
            pnCategory.Controls.Add(item);
            btnCategoryAdd.Enabled = false;
            btnCategoryModify.Enabled = false;
        }
        private void btnInsuranceAdd_Click(object sender, EventArgs e)
        {
            insuranceFlag = true;
            btnInsuranceModify.PerformClick();

            ContentIdItem item = new ContentIdItem();
            item.lbID.Text = "";
            item.txtContent.BorderStyle = BorderStyle.FixedSingle;
            item.txtContent.ReadOnly = false;
            item.btnSave.Visible = true;
            item.btnSave.Click += InsuranceInsert_Click;
            item.Visible = true;
            item.Location = new System.Drawing.Point(0, 0);
            item.Dock = DockStyle.Top;
            pnInsurance.Controls.Add(item);
            btnInsuranceAdd.Enabled = false;
            btnInsuranceModify.Enabled = false;
        }
        private void BrandReload()
        {
            pnBrand.Controls.Clear();
            btnBrandModify.Enabled = true;
            btnBrandAdd.Enabled = true;
            BrandLoadData();
        }
        private void CategoryReload()
        {
            pnCategory.Controls.Clear();
            btnCategoryModify.Enabled = true;
            btnCategoryAdd.Enabled = true;
            CategoryLoadData();
        }
        private void InsuranceReload()
        {
            pnInsurance.Controls.Clear();
            btnInsuranceModify.Enabled = true;
            btnInsuranceAdd.Enabled = true;
            InsuranceLoadData();
        }
        private void lbBrand_Click(object sender, EventArgs e)
        {
            BrandReload();
        }
        private void lbCategory_Click(object sender, EventArgs e)
        {
            CategoryReload();
        }
        private void lbInsurance_Click(object sender, EventArgs e)
        {
            InsuranceReload();
        }
    }
}
