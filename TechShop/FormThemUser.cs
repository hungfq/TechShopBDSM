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

    public partial class FormThemUser : Form
    {

        DbRole dbRole = new DbRole();
        DataTable dtRole = new DataTable();
        DbUser dbUser = new DbUser();
        public FormThemUser()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                
                dtRole.Clear();
                dtRole = dbRole.getAll().Tables[0];


                cbRole.DisplayMember = "name";
                cbRole.ValueMember = "role_id";
                cbRole.DataSource = dtRole;
                cbRole.SelectedItem = null;
                cbRole.Text = " Chọn role:";

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
                this.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbUser.insertUser(ref err, txtName.Text, txtSDT.Text,
                    Int32.Parse(cbRole.SelectedValue.ToString()),txtUsername.Text,
                    txtPassword.Text);
                if (status)
                {
                    MessageBox.Show("Them thanh cong");
                    btnExit.PerformClick();
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
