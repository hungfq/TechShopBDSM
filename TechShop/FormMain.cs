using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop
{
    public partial class FormMain : Form
    {
        FormDsSanPham formDsSanPham = new FormDsSanPham();
        FormDsKhachHang formDsKhachHang = new FormDsKhachHang();
        FormDashboard frmDashboard = new FormDashboard();
        FormBanHang frmBanHang = new FormBanHang();
        FormDonHang frmDonHang = new FormDonHang();
        FormLogin frmLogin = new FormLogin();
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //this.WindowState = FormWindowState.Maximized;
            sidePanel.Dispose();
            btnSignOut.PerformClick();

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnDashboard);
            OpenChildForm(frmDashboard);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnBanHang);
            OpenChildForm(frmBanHang);
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
            formDsSanPham.LoadData();
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


        private void btnSetting_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnSetting);
            pnSettingSubMenu.Visible = true;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            OpenChildForm(frmLogin);
            frmLogin.txtUsername.Focus();
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
        }
        private void hideSubmenu()
        {
            pnBaoCaoSubmenu.Visible = false;
            pnSettingSubMenu.Visible = false;
        }
    }     
}
