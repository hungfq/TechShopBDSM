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
    public partial class FormUser : Form
    {
        List<UserItem> userItem;
        List<User> user;
        DbUser dbUser;
        DataTable dtUser = null;
        DbRole dbRole = new DbRole();
        public FormUser()
        {
            InitializeComponent();
            dbUser = new DbUser();
        }
        public void LoadData()
        {
            userItem = new List<UserItem>();
            user = new List<User>();
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtKhachHang 
                dtUser = new DataTable();
                dtUser.Clear();
                dtUser = dbUser.getAllUser().Tables[0];


                user = Model.ConvertDataTable<User>(dtUser);

                int x = 0;
                foreach (User i in user)
                {
                    UserItem item = new UserItem();
                    item.lbName.Text = i.name;
                    item.lbID.Text = i.user_id.ToString();
                    //item.lbRole.Text = i.role_id.ToString();
                    item.lbRole.Text = dbRole.getRoleByID(i.role_id.ToString()).Tables[0].Rows[0][1].ToString();
                    item.lbUsername.Text = i.username;
                    item.lbPhoneNum.Text = i.phone_number.ToString();
                    item.btnModify.Text = i.user_id.ToString();
                    item.btnModify.Click += btnModify_Click;

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsSp.Controls.Add(item);
                    userItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormSuaUser form = new FormSuaUser(((Button)sender).Text)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Show();

            form.btnReturn.Click += btnReturn_Click;
            form.btnHuy.Click += btnReturn_Click;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbUser = new DbUser();
            LoadData();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormThemUser form = new FormThemUser()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Show();

            form.btnReturn.Click += btnReturn_Click;
            form.btnExit.Click += btnReturn_Click;
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (UserItem i in pnDsSp.Controls)
            {
                i.ck.Checked = ckAll.Checked;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnDsSp.Controls.Clear();
            userItem = new List<UserItem>();
            user = new List<User>();

            /*try
            {
                string name = "";
                name = txtSearch.Text;
                dtUser = new DataTable();
                dtUser.Clear();
                dtUser = dbUser.getAllCustomer(name).Tables[0];

                user = Model.ConvertDataTable<User>(dtUser);

                int x = 0;
                foreach (User i in user)
                {
                    UserItem item = new UserItem();
                    item.lbName.Text = i.name;
                    item.lbAge.Text = i.age.ToString();
                    item.lbID.Text = i.customer_id.ToString();
                    item.lbPhoneNum.Text = i.phone_number.ToString();
                    item.btnModify.Text = i.customer_id.ToString();
                    item.btnModify.Click += btnModify_Click;

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDsSp.Controls.Add(item);
                    userItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }
            }
            catch (Exception eee)
            {
                //MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
                MessageBox.Show(eee.ToString());
            }*/
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            dbUser = new DbUser();
            LoadData();
        }
    }
}
