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
    public partial class FormMain : Form
    {
        FormUser frmUser = new FormUser();
        FormDanhMuc frmDanhMuc = new FormDanhMuc();
        FormDsSanPham formDsSanPham = new FormDsSanPham();
        FormDsKhachHang formDsKhachHang = new FormDsKhachHang();
        FormDashboard frmDashboard = new FormDashboard();
        FormBanHang frmBanHang = new FormBanHang();
        FormDonHang frmDonHang = new FormDonHang();
        FormLogin frmLogin = new FormLogin();
        DbOrder dbOrder = new DbOrder();
        DbUser dbUser = new DbUser();
        DataTable dtUser = new DataTable();
        int user_id = -1;
        string role = "";
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            sidePanel.Dispose();
            btnSignOut.PerformClick();
            frmLogin.btnSubmit.Click += btnSubmit_click;
        }
        private void role_none()
        {
            btnBanHang.Visible = false;
            btnDashboard.Visible = false;
            btnDonHang.Visible = false;
            btnSanPham.Visible = false;
            btnKhachHang.Visible = false;
            btnBaoCao.Visible = false;
            btnManager.Visible = false;
        }
        private void role_admin()
        {
            btnBanHang.Visible = true;
            btnDashboard.Visible = true;
            btnDonHang.Visible = true;
            btnSanPham.Visible = true;
            btnKhachHang.Visible = true;
            btnBaoCao.Visible = true;
            btnManager.Visible = true;
        }
        private void role_user()
        {
            btnBanHang.Visible = true;
            btnDashboard.Visible = true;
            btnSanPham.Visible = true;
            btnKhachHang.Visible = true;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnDashboard);
            OpenChildForm(frmDashboard);
            frmDashboard.LoadData();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnBanHang);
            OpenChildForm(frmBanHang);
            frmBanHang.id = user_id;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnDonHang);
            OpenChildForm(frmDonHang);
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnSanPham);
            OpenChildForm(formDsSanPham);
            //formDsSanPham.LoadData();
        }
        public void btnDsSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(formDsSanPham);
            formDsSanPham.LoadData();
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnKhachHang);
            OpenChildForm(formDsKhachHang);
            formDsKhachHang.LoadData();

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnBaoCao);
            pnBaoCaoSubmenu.Visible = true;
        }


        private void btnManager_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnManager);
            pnManagerSubMenu.Visible = true;
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            user_id = -1;
            role = "";
            resetBtnBackColor();
            hideSubmenu();
            role_none();
            OpenChildForm(frmLogin);
            frmLogin.txtUsername.Focus();
            txtName.Text = "username";

        }
        private void btnSubmit_click(object sender, EventArgs e)
        {
            //frmLogin.dgv.DataSource = dbUser.checkLogin(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text).Tables[0];
            string o = dbUser.checkLogin2(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text).ToString();
            if (Int32.Parse(o) > 0)
            {
                dtUser.Clear();
                try
                {
                    dtUser = dbUser.getUserInfo(o).Tables[0];
                    user_id = Int32.Parse(dtUser.Rows[0]["id"].ToString());
                    role = dtUser.Rows[0]["r_name"].ToString();
                    txtName.Text = dtUser.Rows[0]["u_name"].ToString();
                }
                catch (Exception ê)
                {
                    MessageBox.Show(ê.ToString());
                }
                if (role == "ADMIN")
                {
                    role_admin();
                    btnDashboard.PerformClick();
                }
                else if (role == "MANAGER")
                {
                    role_user();
                    btnDashboard.PerformClick();
                }
            }
            else
            {
                role_none();
            }
            frmLogin.txtUsername.Text = null;
            frmLogin.txtPassword.Text = null;

        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            //hideSubmenu();
            setBtnBackColor(btnDanhMuc);
            OpenChildForm(frmDanhMuc);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            //hideSubmenu();
            setBtnBackColor(btnUser);
            OpenChildForm(frmUser);
            frmUser.LoadData();
        }
        private void setBtnBackColor(Button a)
        {
            a.BackColor = Color.FromArgb(41, 112, 189);
        }
        private void resetBtnBackColor()
        {
            foreach (var i in pnCtrl.Controls.OfType<Button>())
            {
                i.BackColor = Color.FromArgb(32, 45, 63);
            }
            foreach (var i in pnCtrl.Controls.OfType<Panel>())
            {
                foreach (var j in i.Controls.OfType<Button>())
                {
                    j.BackColor = Color.FromArgb(32, 45, 63);
                }
            }
        }
        private void hideSubmenu()
        {
            pnBaoCaoSubmenu.Visible = false;
            pnManagerSubMenu.Visible = false;
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
