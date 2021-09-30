
namespace TechShop
{
    partial class OrderDetailItem
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
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(1056, 16);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(122, 23);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Ngày giao dịch";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(294, 16);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(61, 23);
            this.lbProductName.TabIndex = 17;
            this.lbProductName.Text = "Tên sp";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderID.Location = new System.Drawing.Point(105, 16);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(82, 23);
            this.lbOrderID.TabIndex = 16;
            this.lbOrderID.Text = "Mã order";
            // 
            // OrderDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbOrderID);
            this.Name = "OrderDetailItem";
            this.Size = new System.Drawing.Size(1190, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbQuantity;
        public System.Windows.Forms.Label lbProductName;
        public System.Windows.Forms.Label lbOrderID;
    }
}
