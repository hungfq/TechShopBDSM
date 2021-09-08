using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace TechShop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            txtUsername.Text = "Enter your username...";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = "Enter your password...";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.KeyPress += (sndr, ev) =>
            {
                if (ev.KeyChar.Equals((char)13))
                {
                    btnSubmit.PerformClick();
                    ev.Handled = true; // suppress default handling
                }
            };
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your username...")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter your username...";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter your password...";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = txtUsername.PasswordChar ;
            }
        }
    }
}
