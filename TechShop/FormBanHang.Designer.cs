
namespace TechShop
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.pnListItem = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTienThua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnCart = new System.Windows.Forms.Panel();
            this.ecThToan = new TechShop.ElipseControl();
            this.ecHuy = new TechShop.ElipseControl();
            this.ecPnSearch = new TechShop.ElipseControl();
            this.pnSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(643, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 48);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(588, 32);
            this.txtSearch.TabIndex = 57;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Location = new System.Drawing.Point(12, 33);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(737, 46);
            this.pnSearch.TabIndex = 58;
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(498, 103);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(251, 35);
            this.cbCategory.TabIndex = 59;
            this.cbCategory.Text = "Chọn loại sản phẩm";
            // 
            // cbBrand
            // 
            this.cbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrand.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(268, 103);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(200, 35);
            this.cbBrand.TabIndex = 58;
            this.cbBrand.Text = "Chọn nhãn hiệu";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCustomer.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(773, 347);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(439, 35);
            this.cbCustomer.TabIndex = 60;
            this.cbCustomer.Text = "  Khách hàng";
            // 
            // pnListItem
            // 
            this.pnListItem.AutoScroll = true;
            this.pnListItem.BackColor = System.Drawing.Color.White;
            this.pnListItem.Location = new System.Drawing.Point(12, 154);
            this.pnListItem.Name = "pnListItem";
            this.pnListItem.Size = new System.Drawing.Size(737, 678);
            this.pnListItem.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTienThua);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTienKhachDua);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbTotalMoney);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(773, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 236);
            this.panel3.TabIndex = 60;
            // 
            // lbTienThua
            // 
            this.lbTienThua.AutoSize = true;
            this.lbTienThua.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTienThua.Location = new System.Drawing.Point(327, 179);
            this.lbTienThua.Name = "lbTienThua";
            this.lbTienThua.Size = new System.Drawing.Size(81, 38);
            this.lbTienThua.TabIndex = 60;
            this.lbTienThua.Text = "0000";
            this.lbTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tiền thừa:";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienKhachDua.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhachDua.Location = new System.Drawing.Point(238, 115);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(171, 39);
            this.txtTienKhachDua.TabIndex = 58;
            this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            this.txtTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền khách đưa:";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Open Sans Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalMoney.Location = new System.Drawing.Point(313, 10);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(96, 45);
            this.lbTotalMoney.TabIndex = 2;
            this.lbTotalMoney.Text = "0000";
            this.lbTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(168)))), ((int)(((byte)(79)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThanhToan.Location = new System.Drawing.Point(890, 657);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(322, 175);
            this.btnThanhToan.TabIndex = 61;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkGray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHuy.Location = new System.Drawing.Point(773, 657);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 175);
            this.btnHuy.TabIndex = 62;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnCart
            // 
            this.pnCart.AutoScroll = true;
            this.pnCart.BackColor = System.Drawing.Color.White;
            this.pnCart.Location = new System.Drawing.Point(773, 33);
            this.pnCart.Name = "pnCart";
            this.pnCart.Size = new System.Drawing.Size(439, 291);
            this.pnCart.TabIndex = 60;
            // 
            // ecThToan
            // 
            this.ecThToan.CornerRadius = 10;
            this.ecThToan.TargetControl = this.btnThanhToan;
            // 
            // ecHuy
            // 
            this.ecHuy.CornerRadius = 10;
            this.ecHuy.TargetControl = this.btnHuy;
            // 
            // ecPnSearch
            // 
            this.ecPnSearch.CornerRadius = 25;
            this.ecPnSearch.TargetControl = this.pnSearch;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1234, 844);
            this.Controls.Add(this.pnCart);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.pnListItem);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Panel pnListItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTienThua;
        private System.Windows.Forms.Panel pnCart;
        private ElipseControl ecThToan;
        private ElipseControl ecHuy;
        private ElipseControl ecPnSearch;
    }
}