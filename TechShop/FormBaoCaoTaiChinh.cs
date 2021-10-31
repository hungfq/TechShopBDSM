using AppTier;
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
    public partial class FormBaoCaoTaiChinh : Form
    {
        DbOrder dbOrder = new DbOrder();
        DataTable dtChart = new DataTable();
        DataTable dtCombobox = new DataTable();
        public FormBaoCaoTaiChinh()
        {
            InitializeComponent();
        }

        private void FormBaoCaoTaiChinh_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        public void LoadData()
        {
            LoadComboboxData();
            DrawChart();
        }
        public void Reset()
        {
            this.Controls.Clear();
            InitializeComponent();
            dbOrder = new DbOrder();
            dtChart = new DataTable();
            dtCombobox = new DataTable();
            LoadData();
        } 
        public void DrawChart()
        {
            chart1.BackColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            dtChart.Clear();
            dtChart = dbOrder.CountTotalbyYear(cbYear.SelectedValue.ToString()).Tables[0];
            chart1.DataSource = dtChart;
            chart1.Series["DoanhThu"].XValueMember = "Tháng";
            chart1.Series["DoanhThu"].YValueMembers = "Doanh thu";
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;

            chart1.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gray;

            chart1.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gray;

            chart1.Legends[0].Enabled = false;
        }
        public void LoadComboboxData()
        {
            dtCombobox.Clear();
            dtCombobox = dbOrder.find_YearsInOrder().Tables[0];

            cbYear.DisplayMember = "years";
            cbYear.ValueMember = "years";
            cbYear.DataSource = dtCombobox;
            cbYear.SelectedIndex = 0;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
