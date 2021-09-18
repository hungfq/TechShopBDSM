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
        public FormDanhMuc()
        {
            InitializeComponent();
            BrandLoadData();
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
        private void BrandReload()
        {
            pnBrand.Controls.Clear();
            btnBrandModify.Enabled = true;
            btnBrandAdd.Enabled = true;
            BrandLoadData();
        }
        private void lbBrand_Click(object sender, EventArgs e)
        {
            BrandReload();
        }
    }
}
