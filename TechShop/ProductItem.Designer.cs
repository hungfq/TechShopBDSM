
namespace TechShop
{
    partial class ProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.ck = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbInsuarence = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ck
            // 
            this.ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck.Location = new System.Drawing.Point(32, 21);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(18, 18);
            this.ck.TabIndex = 0;
            this.ck.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(144, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Chỗ này để tên";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(551, 19);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(64, 23);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "giá đây";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.Location = new System.Drawing.Point(764, 19);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(74, 23);
            this.lbBrand.TabIndex = 4;
            this.lbBrand.Text = "BrandID";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(654, 19);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(98, 23);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "CategoryID";
            // 
            // lbInsuarence
            // 
            this.lbInsuarence.AutoSize = true;
            this.lbInsuarence.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsuarence.Location = new System.Drawing.Point(895, 19);
            this.lbInsuarence.Name = "lbInsuarence";
            this.lbInsuarence.Size = new System.Drawing.Size(97, 23);
            this.lbInsuarence.TabIndex = 6;
            this.lbInsuarence.Text = "Insuarence";
            this.lbInsuarence.Click += new System.EventHandler(this.lbInsuarence_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(78, 19);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 23);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID";
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.Location = new System.Drawing.Point(1009, 19);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(58, 23);
            this.lbImage.TabIndex = 3;
            this.lbImage.Text = "image";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(1086, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(79, 60);
            this.btnModify.TabIndex = 42;
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbInsuarence);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ck);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(1165, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbPrice;
        public System.Windows.Forms.Label lbBrand;
        public System.Windows.Forms.Label lbCategory;
        public System.Windows.Forms.Label lbInsuarence;
        public System.Windows.Forms.Label lbImage;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.CheckBox ck;
        public System.Windows.Forms.Button btnModify;
    }
}
