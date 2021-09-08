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

namespace TechShop
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            chart1.BackColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
        }
    }
}
