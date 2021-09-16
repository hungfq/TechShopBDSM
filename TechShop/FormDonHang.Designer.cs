
namespace TechShop
{
    partial class FormDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckAll = new System.Windows.Forms.CheckBox();
            this.pnDsOrder = new System.Windows.Forms.Panel();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 56);
            this.panel1.TabIndex = 55;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(32, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(244, 33);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Danh sách đơn hàng";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày giao dịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(978, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tổng số tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Khách hàng";
            // 
            // ckAll
            // 
            this.ckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAll.Location = new System.Drawing.Point(41, 136);
            this.ckAll.Name = "ckAll";
            this.ckAll.Size = new System.Drawing.Size(18, 18);
            this.ckAll.TabIndex = 42;
            this.ckAll.UseVisualStyleBackColor = true;
            this.ckAll.CheckedChanged += new System.EventHandler(this.ckAll_CheckedChanged);
            // 
            // pnDsOrder
            // 
            this.pnDsOrder.AutoScroll = true;
            this.pnDsOrder.BackColor = System.Drawing.Color.White;
            this.pnDsOrder.Location = new System.Drawing.Point(11, 180);
            this.pnDsOrder.Name = "pnDsOrder";
            this.pnDsOrder.Size = new System.Drawing.Size(1198, 652);
            this.pnDsOrder.TabIndex = 41;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomer.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(861, 74);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(348, 35);
            this.cbCustomer.TabIndex = 51;
            this.cbCustomer.Text = "  Khách hàng";
            this.cbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cbCustomer_SelectionChangeCommitted);
            this.cbCustomer.SelectedValueChanged += new System.EventHandler(this.cbCustomer_SelectedValueChanged);
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 844);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckAll);
            this.Controls.Add(this.pnDsOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox ckAll;
        private System.Windows.Forms.Panel pnDsOrder;
        private System.Windows.Forms.ComboBox cbCustomer;
    }
}