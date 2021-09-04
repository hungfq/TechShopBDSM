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
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
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
        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //this.WindowState = FormWindowState.Maximized;
            sidePanel.Dispose();
            btnDashboard.PerformClick();

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
            pnDonHangSubMenu.Visible = true;
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            resetBtnBackColor();
            hideSubmenu();
            setBtnBackColor(btnSanPham);
            pnSanPhamSubmenu.Visible = true;
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
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //sidePanel.Height = btnSignOut.Height;
            //sidePanel.Top = btnSignOut.Top;
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
            pnDonHangSubMenu.Visible = false;
            pnSanPhamSubmenu.Visible = false;
            pnBaoCaoSubmenu.Visible = false;
        }

        



        
    }     
}
