
namespace TechShop
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            this.lbID = new System.Windows.Forms.Label();
            this.lbSoldDate = new System.Windows.Forms.Label();
            this.lbSale = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ck = new System.Windows.Forms.CheckBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(75, 19);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 23);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // lbSoldDate
            // 
            this.lbSoldDate.AutoSize = true;
            this.lbSoldDate.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoldDate.Location = new System.Drawing.Point(732, 19);
            this.lbSoldDate.Name = "lbSoldDate";
            this.lbSoldDate.Size = new System.Drawing.Size(122, 23);
            this.lbSoldDate.TabIndex = 14;
            this.lbSoldDate.Text = "Ngày giao dịch";
            // 
            // lbSale
            // 
            this.lbSale.AutoSize = true;
            this.lbSale.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSale.Location = new System.Drawing.Point(532, 19);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(89, 23);
            this.lbSale.TabIndex = 12;
            this.lbSale.Text = "Nhân viên";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(967, 19);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(104, 23);
            this.lbTotalMoney.TabIndex = 11;
            this.lbTotalMoney.Text = "Tổng số tiền";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(150, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 23);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Chỗ này để tên";
            // 
            // ck
            // 
            this.ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck.Location = new System.Drawing.Point(29, 21);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(18, 18);
            this.ck.TabIndex = 8;
            this.ck.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(1097, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(93, 60);
            this.btnView.TabIndex = 41;
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbSoldDate);
            this.Controls.Add(this.lbSale);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ck);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1190, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Label lbSoldDate;
        public System.Windows.Forms.Label lbSale;
        public System.Windows.Forms.Label lbTotalMoney;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.CheckBox ck;
        public System.Windows.Forms.Button btnView;
    }
}
