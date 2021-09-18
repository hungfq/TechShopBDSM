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
    public partial class FormSuaUser : Form
    {
        DbRole dbRole = new DbRole();
        DataTable dtRole = new DataTable();
        DbUser dbUser;
        DataTable dtUser;
        List<User> userList = new List<User>();
        string oddID;
        public FormSuaUser(string id)
        {
            InitializeComponent();
            dbUser = new DbUser();
            oddID = id;
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

                dtUser = new DataTable();
                dtUser.Clear();
                dtUser = dbUser.getUser(oddID).Tables[0];

                userList = Model.ConvertDataTable<User>(dtUser);

                txtName.Text = userList[0].name;
                txtPassword.Text = userList[0].password;
                txtSDT.Text = userList[0].phone_number;
                txtUsername.Text = userList[0].username;
                cbRole.SelectedValue = userList[0].role_id;


            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbUser = new DbUser();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool status = dbUser.updateUser(ref err, oddID,txtName.Text, txtSDT.Text,
                     Int32.Parse(cbRole.SelectedValue.ToString()), txtUsername.Text,
                     txtPassword.Text);
                if (status)
                {
                    btnReturn.PerformClick();
                    MessageBox.Show("Sua thanh cong");
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
                bool status = dbUser.deleteUser(ref err, oddID);
                if (status)
                {
                    MessageBox.Show("Xoa thanh cong");
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
