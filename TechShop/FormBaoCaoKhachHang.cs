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
    public partial class FormBaoCaoKhachHang : Form
    {
        DbOrder dbOrder = new DbOrder();
        DataTable dt = new DataTable();
        public FormBaoCaoKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dt.Clear();
                dt = dbOrder.view_OrderFromCustomer().Tables[0];
                List<BaoCaoKhachHangItem> listItem = new List<BaoCaoKhachHangItem>();
                int x = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    BaoCaoKhachHangItem item = new BaoCaoKhachHangItem();
                    item.lbID.Text = dr["MaKH"].ToString();
                    item.lbTenKH.Text = dr["TenKhachHang"].ToString();
                    item.lbSoLuong.Text = dr["SoLuongDonHang"].ToString();
                    item.lbDoanhThu.Text = dr["DoanhThu"].ToString();

                    item.Visible = true;
                    item.Location = new System.Drawing.Point(0, x);
                    pnDs.Controls.Add(item);
                    listItem.Add(item);
                    x += Int32.Parse(item.Height.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
                this.Close();
            }
        }
    }
}
