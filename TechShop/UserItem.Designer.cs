
namespace TechShop
{
    partial class UserItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItem));
            this.btnModify = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ck = new System.Windows.Forms.CheckBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(1025, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(79, 60);
            this.btnModify.TabIndex = 61;
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(73, 16);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 26);
            this.lbID.TabIndex = 60;
            this.lbID.Text = "ID";
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNum.Location = new System.Drawing.Point(524, 16);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(129, 26);
            this.lbPhoneNum.TabIndex = 59;
            this.lbPhoneNum.Text = "Số điện thoại";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(740, 16);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(51, 26);
            this.lbRole.TabIndex = 58;
            this.lbRole.Text = "Role";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(139, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 26);
            this.lbName.TabIndex = 57;
            this.lbName.Text = "Tên";
            // 
            // ck
            // 
            this.ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck.Location = new System.Drawing.Point(27, 20);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(18, 18);
            this.ck.TabIndex = 56;
            this.ck.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(907, 16);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(104, 26);
            this.lbUsername.TabIndex = 74;
            this.lbUsername.Text = "username";
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbPhoneNum);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ck);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(1108, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Label lbPhoneNum;
        public System.Windows.Forms.Label lbRole;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.CheckBox ck;
        public System.Windows.Forms.Label lbUsername;
    }
}
