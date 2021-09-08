
namespace TechShop
{
    partial class FormLogin
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
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.Main = new TechShop.ElipseControl();
            this.ecSubmit = new TechShop.ElipseControl();
            this.ecUsername = new TechShop.ElipseControl();
            this.ecPassword = new TechShop.ElipseControl();
            this.pnHome.SuspendLayout();
            this.pnUsername.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnHome.Controls.Add(this.pnUsername);
            this.pnHome.Controls.Add(this.btnSubmit);
            this.pnHome.Controls.Add(this.label1);
            this.pnHome.Controls.Add(this.pnPassword);
            this.pnHome.Location = new System.Drawing.Point(307, 220);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(606, 404);
            this.pnHome.TabIndex = 0;
            // 
            // pnUsername
            // 
            this.pnUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.pnUsername.Controls.Add(this.txtUsername);
            this.pnUsername.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUsername.Location = new System.Drawing.Point(26, 105);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(547, 53);
            this.pnUsername.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(21, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(500, 32);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(26, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(547, 53);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPassword.Location = new System.Drawing.Point(26, 198);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(547, 53);
            this.pnPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(500, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1221, 844);
            this.pnBackground.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.CornerRadius = 45;
            this.Main.TargetControl = this.pnHome;
            // 
            // ecSubmit
            // 
            this.ecSubmit.CornerRadius = 45;
            this.ecSubmit.TargetControl = this.btnSubmit;
            // 
            // ecUsername
            // 
            this.ecUsername.CornerRadius = 45;
            this.ecUsername.TargetControl = this.pnUsername;
            // 
            // ecPassword
            // 
            this.ecPassword.CornerRadius = 45;
            this.ecPassword.TargetControl = this.pnPassword;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1221, 844);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Panel pnBackground;
        private ElipseControl Main;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPassword;
        private ElipseControl ecSubmit;
        private ElipseControl ecUsername;
        private ElipseControl ecPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Button btnSubmit;
    }
}