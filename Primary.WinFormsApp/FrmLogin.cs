using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmLogin : Form
    {
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
        }
        public string UserName
        {
            get
            {
                return txtUserName.Text;
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Properties.Settings.Default.ApiBaseUrl;
            this.txtUserName.Text = Properties.Settings.Default.UserName;
            this.txtPassword.Text = Properties.Settings.Default.Password;
            if (txtUserName.Text.Length > 0)
            {
                ActiveControl = txtPassword;
                txtPassword.Focus();
            }
        }
    }
}
