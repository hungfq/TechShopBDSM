
namespace TechShop
{
    partial class FormDonHang_ChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonHang_ChiTiet));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1066, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "ID đơn hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "Sản phẩm";
            // 
            // pnHome
            // 
            this.pnHome.AutoScroll = true;
            this.pnHome.BackColor = System.Drawing.Color.White;
            this.pnHome.Location = new System.Drawing.Point(15, 116);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1192, 716);
            this.pnHome.TabIndex = 50;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(135)))));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(355, 31);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Quay lại danh sách đơn hàng";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 52);
            this.panel2.TabIndex = 55;
            // 
            // FormDonHang_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 844);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonHang_ChiTiet";
            this.Text = "FormDonHang_ChiTiet";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnHome;
        public System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
    }
}