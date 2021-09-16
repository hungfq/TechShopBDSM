using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AppTier;

namespace TechShop
{
    public partial class FormDashboard : Form
    {
        DbOrder dbOrder = new DbOrder();
        DataTable dt = new DataTable();
        
        public FormDashboard()
        {
            InitializeComponent();
        }

        public void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            DrawChart();
            DisplayRevenue();
        }
        public void DisplayRevenue()
        {
            int revenue = dbOrder.getRevenue();

            lbRevenue.Text = "$" + revenue.ToString();
        }
        public void DrawChart()
        {
            chart1.BackColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            dt.Clear();
            dt = dbOrder.CountTotalbyYear("2021").Tables[0];
            chart1.DataSource = dt;
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
        
    }
}
